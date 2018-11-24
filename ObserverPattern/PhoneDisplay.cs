using System;

namespace ObserverPattern
{
    public class PhoneDisplay : IObserver
    {
        public void Update(string message)
        {
            Console.WriteLine("{0} got message: {1}", this.GetType().Name, message);
        }
    }
}