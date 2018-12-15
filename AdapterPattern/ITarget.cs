using System.Collections.Generic;

namespace AdapterPattern
{
    public interface ITarget
    {
        IDictionary<string, string> Request();
    }
}