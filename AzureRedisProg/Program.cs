using Newtonsoft.Json;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Threading;

namespace AzureRedisProg
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ConnectionMultiplexer connection = RediConnection.Connection;

             IDatabase cache= connection.GetDatabase();
            cache.StringSet("key1", "value",TimeSpan.FromSeconds(15));

            cache.StringSet("key2", 25);

            //Thread.Sleep(20000);
            //List<int> ints = new List<int>();
            

            Console.WriteLine(cache.StringGet("key1"));
            Console.WriteLine(cache.StringGet("key2"));

            Employee e007 = new Employee("007", "Davide Columbo", 100);
            Console.WriteLine("Cache response from storing Employee .NET object : " +
            cache.StringSet("e007", JsonConvert.SerializeObject(e007)));

            Employee e007FromCache = JsonConvert.DeserializeObject<Employee>(cache.StringGet("e007"));

            Console.WriteLine("Deserialized Employee .NET object :\n");
            Console.WriteLine("\tEmployee.Name : " + e007FromCache.Name);
            Console.WriteLine("\tEmployee.Id   : " + e007FromCache.Id);
            Console.WriteLine("\tEmployee.Age  : " + e007FromCache.Age + "\n");


        }

       
    }
}
