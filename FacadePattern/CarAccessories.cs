using System;

namespace FacadePattern
{
    public class CarAccessories
    {
        private readonly CarAudio _carAudio = new CarAudio();
        private readonly CarSeats _carSeats = new CarSeats();
        
        public void Build()
        {
            Console.WriteLine("Building car accessories");
            
            _carAudio.Build();
            _carSeats.Build();
        }
    }
}