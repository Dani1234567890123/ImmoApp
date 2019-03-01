using ImmoLib;
using ImmoLib.Locator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImmoApp.ViewModel
{
    [LocatorAttribute("neue Forderung")]
    public class ForderungInsertViewModel : ObservableObject, IPageViewModel
    {
        public string Name
        {
            get
            {
                return "neue Forderung";
            }
        }
    }
}
