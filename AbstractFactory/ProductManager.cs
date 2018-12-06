using System;
using AbstractFactory.CrossCuttigConcern;
using AbstractFactory.Caching.Base;
using AbstractFactory.Logging.Base;

namespace AbstractFactory
{
    public class ProductManager{
        private Factory _factory;
        private BaseLogging _logging;
        private BaseCaching _caching;
        public ProductManager(Factory factory){
            _factory = factory;
            _caching = _factory.CreateCacher();
            _logging = _factory.CreateLogger();
        }
        public void GetAll(){
            Console.WriteLine("Product Listed");
            _caching.Cache();
            _logging.Log();
        }
    }
}