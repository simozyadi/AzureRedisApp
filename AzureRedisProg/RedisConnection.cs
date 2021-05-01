using StackExchange.Redis;
using System;

namespace AzureRedisProg
{
    public class RediConnection
    {
        public RediConnection()
        {
        }

        private static Lazy<ConnectionMultiplexer> lazyConnection = new Lazy<ConnectionMultiplexer>(() =>
        {
            String cachConnection = "put sas connection";
            return ConnectionMultiplexer.Connect(cachConnection);
        }
           );


        public static ConnectionMultiplexer Connection
        {
            get
            {
                return lazyConnection.Value;
            }
        }
    }

}
