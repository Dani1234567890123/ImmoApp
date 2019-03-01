using ImmoLib.Locator.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ImmoLib.Locator
{
    internal class ViewModelLocator : ILocator
    {
        private Dictionary<string, object> registeredInstances = new Dictionary<string, object>();

        public ViewModelLocator()
        {
            FindViewModels();
        }

        #region ILocator Members

        public void Register(string name, object o)
        {
            if (String.IsNullOrEmpty(name))
                throw new ArgumentNullException("name");

            if (!registeredInstances.ContainsKey(name))
                registeredInstances.Add(name, o);
            else throw new AlreadyRegisteredException(String.Format("Instance with name '{0}' already registered", name));
        }

        public object GetInstance(string name)
        {
            if (registeredInstances.ContainsKey(name))
                return registeredInstances[name];
            return null;
        }

        public object this[string name]
        {
            get
            {
                return GetInstance(name);
            }
        }

        public void Reset()
        {
            registeredInstances.Clear();
            FindViewModels();
        }

        #endregion

        private void FindViewModels()
        {
            Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
            foreach (Assembly currentAssembly in assemblies)
            {
                foreach (Type currentType in currentAssembly.GetTypes())
                {
                    foreach (object customAttribute in currentType.GetCustomAttributes(true))
                    {
                        LocatorAttribute locAttribute = customAttribute as LocatorAttribute;
                        if (locAttribute != null)
                        {
                            if (!registeredInstances.ContainsKey(locAttribute.Name))
                            {
                                object instance = Activator.CreateInstance(currentType);
                                registeredInstances.Add(locAttribute.Name, instance);
                            }

                        }
                    }
                }
            }
        }
    }
}
