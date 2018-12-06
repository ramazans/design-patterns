using AbstractFactory.Caching.Base;
using AbstractFactory.Logging.Base;
namespace AbstractFactory.CrossCuttigConcern
{
    public abstract class Factory{
        public abstract BaseLogging CreateLogger();
        public abstract BaseCaching CreateCacher();
    }
}