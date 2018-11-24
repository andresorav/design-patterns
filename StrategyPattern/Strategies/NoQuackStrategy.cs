namespace StrategyPattern.Strategies
{
    public class NoQuackStrategy : IQuackStrategy
    {
        public string Run()
        {
            return "Doesn't quack";
        }
    }
}