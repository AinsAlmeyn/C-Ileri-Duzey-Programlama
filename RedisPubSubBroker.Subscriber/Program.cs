using System;
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
await subscriber.SubscribeAsync("mychannel", (channel, message) =>
{
    global::System.Console.WriteLine(message);
});

//await subscriber.SubscribeAsync("stock.*", (channel, message) => // Coklu kanal kullanma ve filtreleme
//{
//    global::System.Console.WriteLine(message);
//});

Console.Read();