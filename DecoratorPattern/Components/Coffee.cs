namespace DecoratorPattern.Components
{
    public class Coffee : AbstractBeverage
    {
        private const double Price = 1;

        public override double GetPrice()
        {
            return Price;
        }
    }
}