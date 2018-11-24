namespace StrategyPattern.Strategies
{
    public class SimpleQuackStrategy : IQuackStrategy
    {
        public string Run()
        {
            return "Quack quack quack";
        }
    }
}