using System;
using System.Collections.Generic;
using AbstractFactoryPattern.Factories;
using AbstractFactoryPattern.Products;

namespace AbstractFactoryPattern
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var lowerProductFactory = new LowerProductFactory();
            var lowerProducts = lowerProductFactory.GetProducts("One", "Two");

            WriteProductNames(lowerProductFactory.GetType().Name, lowerProducts);
            
            var upperProductFactory = new UpperProductFactory();
            var upperProducts = upperProductFactory.GetProducts("One", "Two");

            WriteProductNames(upperProductFactory.GetType().Name, upperProducts);
            
            var mixedProductFactory = new MixedProductFactory();
            var mixedProducts = mixedProductFactory.GetProducts("One", "Two");

            WriteProductNames(mixedProductFactory.GetType().Name, mixedProducts);
        }

        private static void WriteProductNames(string factoryName, IEnumerable<AbstractProduct> products)
        {
            foreach (var product in products)
            {
                Console.WriteLine("Product from {0}: {1}", factoryName, product.GetName());
            }
        }
    }
}