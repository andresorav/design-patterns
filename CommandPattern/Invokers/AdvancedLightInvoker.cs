using CommandPattern.Commands;

namespace CommandPattern.Invokers
{
    public interface IAdvancedLightInvoker : ILightInvoker
    {
        void DimLightDown();
        void DimLightUp();
    }
    
    public class AdvancedLightInvoker : IAdvancedLightInvoker
    {
        private readonly ICommand _onCommand;
        private readonly ICommand _offCommand;
        private readonly ICommand _dimUpCommand;
        private readonly ICommand _dimDownCommand;

        public AdvancedLightInvoker(ICommand onCommand, ICommand offCommand, ICommand dimUpCommand, ICommand dimDownCommand)
        {
            _onCommand = onCommand;
            _offCommand = offCommand;
            _dimUpCommand = dimUpCommand;
            _dimDownCommand = dimDownCommand;
        }

        public void LightOn()
        {
            _onCommand.Execute();
        }

        public void LightOff()
        {
            _offCommand.Execute();
        }

        public void DimLightDown()
        {
            _dimDownCommand.Execute();
        }

        public void DimLightUp()
        {
            _dimUpCommand.Execute();
        }
    }
}