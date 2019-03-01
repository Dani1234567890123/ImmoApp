using ImmoLib;
using ImmoLib.Locator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImmoApp.ViewModel
{
    [LocatorAttribute("Dokument bearbeiten")]
    public class DokumentUpdateViewModel : ObservableObject, IPageViewModel
    {
        public string Name
        {
            get
            {
                return "Dokument bearbeiten";
            }
        }
    }
}
