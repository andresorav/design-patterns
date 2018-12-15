using CommandPattern.Commands;
using CommandPattern.Invokers;
using CommandPattern.Receivers;

namespace CommandPattern
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var light = new Light();
            
            var advancedLightInvoker = new AdvancedLightInvoker(
                new LightOnCommand(light), 
                new LightOffCommand(light), 
                new DimUpCommand(light),
                new DimDownCommand(light));

            advancedLightInvoker.LightOn();
            advancedLightInvoker.LightOff();
            advancedLightInvoker.DimLightDown();
            advancedLightInvoker.DimLightUp();
            
            var simpleInvoker = new SimpleLightInvoker(new LightOnCommand(light));

            simpleInvoker.LightOn();
            simpleInvoker.LightOff();
        }
    }
}