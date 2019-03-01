using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImmoLib.Locator
{
    public static class ObjectLocator
    {
        private static ILocator locator = new ViewModelLocator();

        public static ILocator Current
        {
            get
            {
                return locator;
            }
        }

        public static void Register(ILocator locatorToRegister)
        {
            if (locatorToRegister == null)
                throw new ArgumentNullException("locatorToRegister");

            locator = locatorToRegister;
        }
    }
}
