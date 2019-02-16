using System;

namespace NullObjectPattern
{
    internal static class Program
    {
        private static void Main()
        {
            var customerDatabase = new CustomerDatabase(new[]
            {
                "Marcus Aurelius", "Sokrates", "Aristotle"
            });

            string[] searchForNames = {"Marcus", "Sokrates", "Aurelius", "Aristotle"};

            foreach (var name in searchForNames)
            {
                var customer = customerDatabase.FindByName(name);

                Console.WriteLine("Searched for: {0} > Found: {1}", name, customer.GetName());
            }
        }
    }
}