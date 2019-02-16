namespace NullObjectPattern
{
    public class NullCustomer : ICustomer
    {
        public string GetName()
        {
            return "Customer not available";
        }
    }
}