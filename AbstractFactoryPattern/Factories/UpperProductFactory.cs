using AbstractFactoryPattern.Products;

namespace AbstractFactoryPattern.Factories
{
    public class UpperProductFactory : AbstractFactory
    {
        protected override AbstractProductA GetProductA(string name)
        {
            return new UpperProductA(name);
        }

        protected override AbstractProductB GetProductB(string name)
        {
            return new UpperProductB(name);
        }
    }
}