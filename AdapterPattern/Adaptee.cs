using System.Collections.Generic;

namespace AdapterPattern
{
    public class Adaptee
    {
        public IDictionary<string, string> SpecificRequest()
        {
            return new Dictionary<string, string>
            {
                {"name", "Request from Adaptee"},
                {"status", "success"}
            };
        }
    }
}