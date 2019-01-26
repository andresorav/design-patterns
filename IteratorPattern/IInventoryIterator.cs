namespace IteratorPattern
{
    public interface IInventoryIterator
    {
        IInventoryItem Current();
        bool HasNext();
        void Next();
    }
}