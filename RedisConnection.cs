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
            String cachConnection = "az-204-cache-for-redis.redis.cache.windows.net:6380,password=cgVHBiLaH5zPKM0c9X3EqDVhS4KPQRF1GG6cqH5O79M=,ssl=True,abortConnect=False";
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
