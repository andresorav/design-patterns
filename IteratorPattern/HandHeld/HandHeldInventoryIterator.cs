namespace IteratorPattern.HandHeld
{
    public class HandHeldInventoryIterator : IInventoryIterator
    {
        private readonly HandHeldInventory _inventory;
        private int _index;
        private const int MaxItems = 2;

        public HandHeldInventoryIterator(HandHeldInventory inventory)
        {
            this._index = 0;
            this._inventory = inventory;
        }
        
        public bool HasNext()
        {
            return _index < MaxItems;
        }

        public void Next()
        {
            this._index += 1;
        }

        public IInventoryItem Current()
        {
            switch (this._index)
            {
                case 0: return this._inventory.Left;
                case 1: return this._inventory.Right;
                default: return null;
            }
        }
    }
}