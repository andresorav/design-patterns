using AbstractFactoryPattern.Products;

namespace AbstractFactoryPattern.Factories
{
    public class MixedProductFactory : AbstractFactory
    {
        protected override AbstractProductA GetProductA(string name)
        {
            return new LowerProductA(name);
        }

        protected override AbstractProductB GetProductB(string name)
        {
            return new UpperProductB(name);
        }
    }
}