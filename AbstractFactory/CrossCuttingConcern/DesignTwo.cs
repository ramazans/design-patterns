using AbstractFactory.Logging;
using AbstractFactory.Logging.Base;
using AbstractFactory.Caching;
using AbstractFactory.Caching.Base;

namespace AbstractFactory.CrossCuttigConcern
{
    public class DesignTwo : Factory{
        public override BaseLogging CreateLogger()
        {
            return new Log4Net();
        }

        public override BaseCaching CreateCacher()
        {
            return new RedisCache();
        }
    }
}