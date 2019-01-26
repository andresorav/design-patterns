namespace IteratorPattern.HandHeld
{
    public class HandHeldInventory : IInventory
    {
        public IInventoryItem Left { get; }
        public IInventoryItem Right { get; }

        public HandHeldInventory(IInventoryItem left, IInventoryItem right)
        {
            this.Left = left;
            this.Right = right;
        }
        
        public IInventoryIterator GetIterator()
        {
            return new HandHeldInventoryIterator(this);
        }
    }
}