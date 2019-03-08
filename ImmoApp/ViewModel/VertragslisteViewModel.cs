using ImmoApp.View;
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
    
    public class VertragslisteViewModel : ObservableObject, IPageViewModel
    {
        public static int übergabeID;
        public static string übergabeObj;
        public static string übergabeMieteinheit;
        public static string übergabeMieter;
        public static string übergabeVermieter;
        public string Name
        {
            get
            {
                return "Mietverträge";
            }
        }
        private vwVerträge _selectedVertrag;            

        public vwVerträge SelectedVertrag
        {
            get { return _selectedVertrag; }
            set {
                if (_selectedVertrag != value)
                {
                    _selectedVertrag = value;
                    übergabeID = _selectedVertrag.Vertragsnr;
                    übergabeObj = _selectedVertrag.Objekt;
                    übergabeMieteinheit = _selectedVertrag.Mieteinheit;
                    übergabeMieter = _selectedVertrag.Mieter;
                    übergabeVermieter = _selectedVertrag.Vermieter;
                    this.OnPropertyChanged();
                }
            }
        }


        private IEnumerable<vwVerträge> _vertragsListe;
        public IEnumerable<vwVerträge> VertragsListe
        {
            get { return _vertragsListe; }
            private set { this.OnPropertyChanged(); }
        }
       
       
       
        public static List<vwVerträge> GetVerträge()
        {
            using (immoEntities context = new immoEntities())
            {
                var query = context.vwVerträge.ToList();
                return query;
            }
        }
        public VertragslisteViewModel()
        {
           
            _vertragsListe = GetVerträge();
            _changeToVertragUpdateCommand = new RelayCommand(param => ChangeToVertragUpdateView(param as UserControl));
            _changeToVertragInsertCommand = new RelayCommand(param => ChangeToVertragInsertView(param as UserControl));

        }
        #region Commands

       
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
        private ICommand _changeToVertragUpdateCommand;
        public ICommand ChangeToVertragUpdateCommand
        {
            get { return _changeToVertragUpdateCommand; }
            set { _changeToVertragUpdateCommand = value; }
        }

        private void ChangeToVertragUpdateView(UserControl name)
        {
                Window win = new Window();
                UserControl uc = new UserControl();
                uc = name;
                win.Content = uc;

                win.Title = FensterTitelFestlegen(win, uc);
                win.Show();
        
        }

        private ICommand _changeToVertragInsertCommand;
        public ICommand ChangeToVertragInsertCommand
        {
            get { return _changeToVertragInsertCommand; }
            set { _changeToVertragInsertCommand = value; }
        }

        private void ChangeToVertragInsertView(UserControl name)
        {
            Window win = new Window();
            UserControl uc = new UserControl();
            uc = name;
            win.Content = uc;

            win.Title = FensterTitelFestlegen(win, uc);
            win.Show();
        }

        private string FensterTitelFestlegen(Window win, UserControl uc)
        {
            string title;
            if (uc is VertragInsertView) { title = "Neuer Vertrag"; }
            else if (uc is VertragUpdateView) { title = "Vertrag bearbeiten"; }
            else title = "neues Fenster";
            return title;
        }
        #endregion
    }
}
