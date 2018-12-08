namespace AbstractFactoryPattern.Products
{
    public class LowerProductB : AbstractProductB
    {
        public LowerProductB(string name) : base(name)
        {
            
        }

        public override string GetName()
        {
            return Name.ToLower();
        }
    }
}