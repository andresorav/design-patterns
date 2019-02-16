using System.Collections.Generic;

namespace NullObjectPattern
{
    public class CustomerDatabase
    {
        private readonly List<ICustomer> _customers = new List<ICustomer>();
        private readonly ICustomer _nullCustomer = new NullCustomer();

        public CustomerDatabase(IEnumerable<string> customerNames)
        {
            foreach (var name in customerNames) _customers.Add(new Customer(name));
        }

        public ICustomer FindByName(string name)
        {
            return _customers.Find(customer => customer.GetName() == name) ?? _nullCustomer;
        }
    }
}