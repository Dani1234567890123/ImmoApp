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
        
        

        public StartPageViewModel()
        {
            _changeViewCommand = new RelayCommand(param => ChangeView((UserControl)param));
        }
        private bool _canExecute = true;
        public bool CanExecute
        {
            get { return this._canExecute; }
            set
            {
                if (this._canExecute == value)
                    return;

                this._canExecute = value;
            }
        }
        private ICommand _changeViewCommand;
        public ICommand ChangeViewCommand
        {
            get { return _changeViewCommand; }
            set { _changeViewCommand = value; }
        }

        private void ChangeView(UserControl name)
        {
            Window win = ViewCreator<Window>.CreateSingletonView();
            UserControl uc = new UserControl();
            uc = name;
            win.Content = uc;
            win.Show();
        }
    }
}
