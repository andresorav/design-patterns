namespace StrategyPattern.Strategies
{
    public class NoFlyStrategy : IFlyStrategy
    {
        public string Run()
        {
            return "Doesn't fly";
        }
    }
}