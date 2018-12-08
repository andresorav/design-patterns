using CommandPattern.Receivers;

namespace CommandPattern.Commands
{
    public class LightOffCommand : ICommand
    {
        private readonly ILight _light;

        public LightOffCommand(ILight light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.Off();
        }

        public void UnExecute()
        {
            _light.On();
        }
    }
}