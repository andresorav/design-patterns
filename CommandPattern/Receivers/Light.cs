using System;
using System.Diagnostics;
using System.Linq;

namespace CommandPattern.Receivers
{
    public interface ILight
    {
        void On();
        void Off();
        void DimUp();
        void DimDown();
    }

    public class Light : ILight
    {
        public void On()
        {
            Console.WriteLine("{0}: Light on", GetCallerClassAndMethod());
        }

        public void Off()
        {
            Console.WriteLine("{0}: Light off", GetCallerClassAndMethod());
        }

        public void DimUp()
        {
            Console.WriteLine("{0}: Dim up...", GetCallerClassAndMethod());
        }

        public void DimDown()
        {
            Console.WriteLine("{0}: Dim down...", GetCallerClassAndMethod());
        }

        private string GetCallerClassAndMethod()
        {
            var frame = new StackFrame(2, true);

            return string.Format(
                "{0}->{1}",
                frame.GetFileName().Split("/").Reverse().First().Replace(".cs", ""),
                frame.GetMethod().Name
            );
        }
    }
}