using CommandPattern.Receivers;

namespace CommandPattern.Commands
{
    public class LightOnCommand : ICommand
    {
        private readonly ILight _light;

        public LightOnCommand(ILight light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.On();
        }

        public void UnExecute()
        {
            _light.Off();
        }
    }
}