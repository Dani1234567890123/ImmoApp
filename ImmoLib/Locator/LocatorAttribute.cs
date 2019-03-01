using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImmoLib.Locator
{
    public class LocatorAttribute : Attribute
    {
        public string Name { get; set; }

        public LocatorAttribute(string name)
        {
            Name = name;
        }
    }
}
