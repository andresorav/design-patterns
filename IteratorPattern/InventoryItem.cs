namespace IteratorPattern
{
    public interface IInventoryItem
    {
        string GetName();
    }

    public class InventoryItem : IInventoryItem
    {
        private readonly string _name;
        
        public InventoryItem(string name)
        {
            _name = name;
        }
        
        public virtual string GetName()
        {
            return $"Inventory Item: {_name}";
        }
    }
}