namespace AbstractFactoryPattern.Products
{
    public class UpperProductB : AbstractProductB
    {
        public UpperProductB(string name) : base(name)
        {
        }

        public override string GetName()
        {
            return Name.ToUpper();
        }
    }
}