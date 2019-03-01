using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImmoLib.Locator
{
    public interface ILocator
    {
        void Register(string name, object o);
        void Reset();
        object GetInstance(string name);
        object this[string name] { get; }
    }
}
