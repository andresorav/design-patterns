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

            WriteProductNames(lowerProducts);
            
            var upperProductFactory = new UpperProductFactory();
            var upperProducts = upperProductFactory.GetProducts("One", "Two");

            WriteProductNames(upperProducts);
        }

        private static void WriteProductNames(List<AbstractProduct> products)
        {
            foreach (var product in products)
            {
                Console.WriteLine("Product {0}", product.GetName());
            }
        }
    }
}