using ImmoLib;
using ImmoLib.Locator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImmoApp.ViewModel
{
    [LocatorAttribute("Erstattungen")]
    public class ErstattungslisteViewModel : ObservableObject, IPageViewModel
    {
        public string Name
        {
            get
            {
                return "Erstattungen";
            }
        }
    }
}
