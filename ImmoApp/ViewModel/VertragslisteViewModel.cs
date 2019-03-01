using ImmoLib;
using ImmoLib.Locator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImmoApp.ViewModel
{
    [LocatorAttribute("Mietverträge")]
    public class VertragslisteViewModel : ObservableObject, IPageViewModel
    {
        public string Name
        {
            get
            {
                return "Mietverträge";
            }
        }

    }
}
