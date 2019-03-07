using ImmoLib;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace ImmoApp.ViewModel
{
  
    public class StartPageViewModel : ObservableObject, IPageViewModel
    {
        public string Name
        {
            get
            {
                return "Startseite";
            }
        }
        
        

        
    }
}
