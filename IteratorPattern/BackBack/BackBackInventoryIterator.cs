namespace IteratorPattern.BackBack
{
    public class BackBackInventoryIterator : IInventoryIterator
    {
        private readonly BackBackInventory _inventory;
        private int _index;

        public BackBackInventoryIterator(BackBackInventory inventory)
        {
            this._index = 0;
            this._inventory = inventory;
        }
        
        public bool HasNext()
        {
            return this._index < this._inventory.InventoryItems.Length;
        }

        public void Next()
        {
            this._index += 1;
        }

        public IInventoryItem Current()
        {
            return this._inventory.InventoryItems[this._index];
        }
    }
}