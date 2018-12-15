using System;

namespace AdapterPattern
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var client = new Client(new Adapter(new Adaptee()));

            Console.WriteLine("Response from client:");
            Console.WriteLine(client.Request());
        }
    }
}