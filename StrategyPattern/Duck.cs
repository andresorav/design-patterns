using StrategyPattern.Strategies;

namespace StrategyPattern
{
    public interface IDuck
    {
        string Quack();
        string Fly();
    }
    
    public class Duck : IDuck
    {
        private readonly IFlyStrategy _flyStrategy;
        private readonly IQuackStrategy _quackStrategy;

        public Duck(IFlyStrategy flyStrategy, IQuackStrategy quackStrategy)
        {
            this._flyStrategy = flyStrategy;
            this._quackStrategy = quackStrategy;
        }

        public string Quack()
        {
            return this._quackStrategy.Run();
        }

        public string Fly()
        {
            return this._flyStrategy.Run();
        }
    }
}