using System;
using System.Threading;

namespace ObserverPattern
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var weatherStation = new WeatherStation();
            var tvDisplay = new TvDisplay();
            var phoneDisplay = new PhoneDisplay();
            
            weatherStation.AddObserver(tvDisplay);
            weatherStation.AddObserver(phoneDisplay);

            while (true)
            {
                weatherStation.Broadcast(string.Format("Hello display {0}", DateTime.UtcNow));
                Thread.Sleep(1000);
            }
        }
    }
}