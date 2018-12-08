namespace AbstractFactoryPattern.Products
{
    public class UpperProductA : AbstractProductA
    {
        public UpperProductA(string name) : base(name)
        {
        }

        public override string GetName()
        {
            return Name.ToUpper();
        }
    }
}