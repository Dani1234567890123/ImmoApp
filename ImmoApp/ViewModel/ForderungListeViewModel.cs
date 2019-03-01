using ImmoLib;
using ImmoLib.Locator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImmoApp.ViewModel
{
    [LocatorAttribute("Forderungen")]
    public class ForderungListeViewModel : ObservableObject, IPageViewModel
    {
        public string Name
        {
            get
            {
                return "Forderungen";
            }
        }
    }
}
