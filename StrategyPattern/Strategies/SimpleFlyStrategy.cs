namespace StrategyPattern.Strategies
{
    public class SimpleFlyStrategy : IFlyStrategy
    {
        public string Run()
        {
            return "And there he goes...";
        }
    }
}