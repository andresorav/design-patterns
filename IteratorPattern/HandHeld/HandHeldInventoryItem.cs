namespace IteratorPattern.HandHeld
{
    public class HandHeldInventoryItem : InventoryItem
    {
        private readonly string _hand;
        public const string Left = "left";
        public const string Right = "right";
        
        public HandHeldInventoryItem(string name, string hand) : base(name)
        {
            _hand = hand;
        }

        public override string GetName()
        {
            return $"{base.GetName()} is in {_hand} a hand";
        }
    }
}