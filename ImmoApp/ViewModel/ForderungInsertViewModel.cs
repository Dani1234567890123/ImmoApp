using ImmoLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImmoApp.ViewModel
{
    public class ForderungInsertViewModel : ObservableObject, IPageViewModel
    {
        public string Name
        {
            get
            {
                return "fivm";
            }
        }
    }
}
