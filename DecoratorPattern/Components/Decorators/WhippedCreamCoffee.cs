namespace DecoratorPattern.Components.Decorators
{
    public class WhippedCreamCoffee : AbstractCoffeeDecorator
    {
        public WhippedCreamCoffee(AbstractBeverage beverage) : base(beverage)
        {
        }

        public override double GetPrice()
        {
            // on the house, no additional cost
            return Beverage.GetPrice();
        }
    }
}