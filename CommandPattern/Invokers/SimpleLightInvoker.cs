using CommandPattern.Commands;

namespace CommandPattern.Invokers
{
    public class SimpleLightInvoker : ILightInvoker
    {
        private readonly ICommand _onCommand;

        public SimpleLightInvoker(ICommand onCommand)
        {
            _onCommand = onCommand;
        }

        public void LightOn()
        {
            _onCommand.Execute();
        }

        public void LightOff()
        {
            _onCommand.UnExecute();
        }
    }
}