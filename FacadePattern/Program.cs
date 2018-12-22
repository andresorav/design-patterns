namespace FacadePattern
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var car = new Car();

            car.Build();
        }
    }
}