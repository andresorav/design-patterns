namespace DecoratorPattern.Components.Decorators
{
    public abstract class AbstractCoffeeDecorator : AbstractBeverage
    {
        protected readonly AbstractBeverage Beverage;

        protected AbstractCoffeeDecorator(AbstractBeverage beverage)
        {
            Beverage = beverage;
        }
    }
}