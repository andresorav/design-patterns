using CommandPattern.Receivers;

namespace CommandPattern.Commands
{
    public class DimDownCommand : ICommand
    {
        private readonly ILight _light;

        public DimDownCommand(ILight light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.DimDown();
        }

        public void UnExecute()
        {
            _light.DimUp();
        }
    }
}