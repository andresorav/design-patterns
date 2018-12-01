namespace DecoratorPattern.Components.Decorators
{
    public class CaramelFlavourCoffee : AbstractCoffeeDecorator
    {
        private const double Price = 5.25;

        public CaramelFlavourCoffee(AbstractBeverage beverage) : base(beverage)
        {
        }

        public override double GetPrice()
        {
            return Beverage.GetPrice() + Price;
        }
    }
}