using System.Collections.Generic;

namespace ObserverPattern
{
    public class WeatherStation : IObservable
    {
        private readonly IList<IObserver> _displays = new List<IObserver>();

        public void RemoveObserver(IObserver display)
        {
            _displays.Remove(display);
        }

        public void AddObserver(IObserver display)
        {
            _displays.Add(display);
        }

        public void Broadcast(string message)
        {
            foreach (var display in _displays)
            {
                display.Update(message);
            }
        }
    }
}