using System;
using AbstractFactory.Caching.Base;

namespace AbstractFactory.Caching
{
    public class RedisCache : BaseCaching{
        public override void Cache(){
            Console.WriteLine("Redis Cache");
        }
    }
}