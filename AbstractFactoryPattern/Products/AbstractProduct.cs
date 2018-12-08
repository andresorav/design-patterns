namespace AbstractFactoryPattern.Products
{
    public abstract class AbstractProduct
    {
        protected readonly string Name;

        protected AbstractProduct(string name)
        {
            Name = string.Format("{0} name is {1}", this.GetType().Name, name);
        }

        public abstract string GetName();
    }
}