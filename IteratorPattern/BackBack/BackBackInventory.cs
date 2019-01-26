namespace IteratorPattern.BackBack
{
    public class BackBackInventory : IInventory
    {
        public IInventoryItem[] InventoryItems { get; }

        public BackBackInventory(IInventoryItem[] inventoryItems)
        {
            this.InventoryItems = inventoryItems;
        }
        
        public IInventoryIterator GetIterator()
        {
            return new BackBackInventoryIterator(this);
        }
    }
}