using StackExchange.Redis;

namespace RedisSentinelUsage.Services
{
    public class RedisService
    {
        static ConfigurationOptions sentinelOptions => new()
        {
            EndPoints =
            {
                { "localhost", 6383 },
                { "localhost", 6384 },
                { "localhost", 6385 }
            },
            CommandMap = CommandMap.Sentinel,
            AbortOnConnectFail = false
        };

        static ConfigurationOptions masterOptions => new()
        {
            AbortOnConnectFail = false
        };

        static public async Task<IDatabase> RedisMasterDatabse()
        {
            System.Net.EndPoint masterEndpoint = null;
            ConnectionMultiplexer sentinelConnection = await ConnectionMultiplexer.SentinelConnectAsync(sentinelOptions);
            foreach (System.Net.EndPoint endpoint in sentinelConnection.GetEndPoints())
            {
                IServer server = sentinelConnection.GetServer(endpoint);
                if (!server.IsConnected)
                    continue;
                masterEndpoint = await server.SentinelGetMasterAddressByNameAsync("mymaster"); //sentinel.conf dosyasindaki bilgiyi al.
                break;
            }
            //docker inspect --format='{{range .NetworkSettings.Networks}}{{.IPAddress}}{{end}}' $(docker ps -aq)
            //komutundan cikan sonuclara gore docker iplerini localhost'a cekiyoruz.
            var localMasterIP = masterEndpoint.ToString() switch
            {
                "172.18.0.2:6379" => "localhost:6379",
                "172.18.0.3:6379" => "localhost:6380",
                "172.18.0.4:6379" => "localhost:6381",
                "172.18.0.5:6379" => "localhost:6382",
            };

            ConnectionMultiplexer masterConnection = await ConnectionMultiplexer.ConnectAsync(localMasterIP);
            IDatabase database = masterConnection.GetDatabase();
            return database;
        }
    }
}