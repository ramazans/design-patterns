using AbstractFactory.Logging;
using AbstractFactory.Logging.Base;
using AbstractFactory.Caching;
using AbstractFactory.Caching.Base;

namespace AbstractFactory.CrossCuttigConcern
{
    public class DesignOne : Factory{
        public override BaseLogging CreateLogger(){
            return new NLogger();
        }

        public override BaseCaching CreateCacher(){
            return new MemCache();
        }
    }
}