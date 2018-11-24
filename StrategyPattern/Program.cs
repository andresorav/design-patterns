using System;
using System.Collections.Generic;
using StrategyPattern.Strategies;

namespace StrategyPattern
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var ducks = new Dictionary<string, IDuck>
            {
                { "Rubber duck", new Duck(new NoFlyStrategy(), new NoQuackStrategy()) },
                { "Simple duck", new Duck(new SimpleFlyStrategy(), new SimpleQuackStrategy()) }
            };
            
            foreach (var keyValuePair in ducks)
            {
                Console.WriteLine(keyValuePair.Key);
                Console.WriteLine(keyValuePair.Value.Quack() + ", " + keyValuePair.Value.Fly());
            }
        }
    }
}