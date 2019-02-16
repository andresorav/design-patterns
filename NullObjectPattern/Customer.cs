namespace NullObjectPattern
{
    public class Customer : ICustomer
    {
        private readonly string _name;

        public Customer(string name)
        {
            _name = name;
        }

        public string GetName()
        {
            return _name;
        }
    }
}