using System;
using AbstractFactory.Caching.Base;

namespace AbstractFactory.Caching
{
    public class MemCache : BaseCaching{
        public override void Cache(){
            Console.WriteLine("MemCache");
        }
    }
}