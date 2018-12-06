using AbstractFactory.CrossCuttigConcern;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager _productManager = new ProductManager(new DesignTwo());
            _productManager.GetAll();
        }
    }
}
