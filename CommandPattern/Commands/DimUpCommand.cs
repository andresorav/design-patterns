using CommandPattern.Receivers;

namespace CommandPattern.Commands
{
    public class DimUpCommand : ICommand
    {
        private readonly ILight _light;

        public DimUpCommand(ILight light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.DimUp();
        }

        public void UnExecute()
        {
            _light.DimDown();
        }
    }
}