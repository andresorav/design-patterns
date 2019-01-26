using System;
using IteratorPattern.BackBack;
using IteratorPattern.HandHeld;

namespace IteratorPattern
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var hhInventory = new HandHeldInventory(
                new HandHeldInventoryItem("Shield", HandHeldInventoryItem.Right),
                new HandHeldInventoryItem("Axe", HandHeldInventoryItem.Left)
            );

            var hhInventoryIterator = hhInventory.GetIterator();
            PrintInventoryItems(hhInventoryIterator);

            var bbInventory = new BackBackInventory(new[]
            {
                new InventoryItem("Map"),
                new InventoryItem("Rope"),
                new InventoryItem("Water")
            });

            var bbInventoryIterator = bbInventory.GetIterator();
            PrintInventoryItems(bbInventoryIterator);
        }

        private static void PrintInventoryItems(IInventoryIterator inventoryIterator)
        {
            while (inventoryIterator.HasNext())
            {
                Console.WriteLine(inventoryIterator.Current().GetName());
                inventoryIterator.Next();
            }
        }
    }
}