using StackExchange.Redis;
ConnectionMultiplexer connection = await ConnectionMultiplexer.ConnectAsync("localhost:1453"
    //,
    //options =>
    //{
    //    options.SslHost = "",
    //    options.Password = "",

    //}
    );
ISubscriber subscriber = connection.GetSubscriber();
while (true)
{
    global::System.Console.Write("Mesaj :");
    string mesaj = Console.ReadLine();
    await subscriber.PublishAsync("mychannel", mesaj);
}