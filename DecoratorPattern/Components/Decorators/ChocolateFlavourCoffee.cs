namespace DecoratorPattern.Components.Decorators
{
    public class ChocolateFlavourCoffee : AbstractCoffeeDecorator
    {
        private const double Price = 5.25;

        public ChocolateFlavourCoffee(AbstractBeverage beverage) : base(beverage)
        {
        }

        public override double GetPrice()
        {
            return Beverage.GetPrice() + Price;
        }
    }
}