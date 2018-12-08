namespace AbstractFactoryPattern.Products
{
    public class LowerProductA : AbstractProductA
    {
        public LowerProductA(string name) : base(name)
        {
        }

        public override string GetName()
        {
            return Name.ToLower();
        }
    }
}