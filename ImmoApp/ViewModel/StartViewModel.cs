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
    public class StartViewModel : ObservableObject
    {
        #region Fields

        private ICommand _changePageCommand;

        private IPageViewModel _currentPageViewModel;
        private List<IPageViewModel> _pageViewModels;
        private Window _win;
        public Window Win
        { get
            {
                if (_win == null)
                    _win = new Window();
                return _win;
            }
            set { this.OnPropertyChanged(); }
        }
        #endregion

        public StartViewModel()
        {
            // Add available pages
            PageViewModels.Add(new StartPageViewModel());
            PageViewModels.Add(new ObjektListeViewModel());
            PageViewModels.Add(new MieteinheitListeViewModel());
            PageViewModels.Add(new VertragslisteViewModel());
            PageViewModels.Add(new KontaktListeViewModel());
            PageViewModels.Add(new EinnahmenListeViewModel());
            PageViewModels.Add(new ForderungListeViewModel());
            PageViewModels.Add(new ErstattungslisteViewModel());
            PageViewModels.Add(new DokumentenListeViewModel());
            PageViewModels.Add(new VorlageListeViewModel());
            PageViewModels.Add(new EinstellungenViewModel());
            // Set starting page
            CurrentPageViewModel = PageViewModels[0];
            _changeViewCommand = new RelayCommand(param => ChangeView(param as UserControl));
        }

        #region Naviagationsbuttons + Methoden

        public ICommand ChangePageCommand
        {
            get
            {
                if (_changePageCommand == null)
                {
                    _changePageCommand = new RelayCommand(
                        p => ChangeViewModel((IPageViewModel)p),
                        p => p is IPageViewModel);
                }

                return _changePageCommand;
            }
        }
        public List<IPageViewModel> PageViewModels
        {
            get
            {
                if (_pageViewModels == null)
                    _pageViewModels = new List<IPageViewModel>();

                return _pageViewModels;
            }
        }

        public IPageViewModel CurrentPageViewModel
        {
            get
            {
                return _currentPageViewModel;
            }
            set
            {
                if (_currentPageViewModel != value)
                {
                    _currentPageViewModel = value;
                    this.OnPropertyChanged();
                }
            }
        }
        public void ChangeViewModel(IPageViewModel viewModel)
        {
            if (!PageViewModels.Contains(viewModel))
                PageViewModels.Add(viewModel);

            CurrentPageViewModel = PageViewModels
                .FirstOrDefault(vm => vm == viewModel);
        }

        #endregion

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
        private ICommand _changeViewCommand;
        public ICommand ChangeViewCommand
        {
            get { return _changeViewCommand; }
            set { _changeViewCommand = value; }
        }

        private void ChangeView(UserControl name)
        {
            Window win = new Window();
            UserControl uc = new UserControl();
            uc = name;
            win.Content = uc;

            win.Title = FensterTitelFestlegen(win, uc);
            win.Show();
        }

        private static string FensterTitelFestlegen(Window win, UserControl uc)
        {
            string title;
            if (uc is BankInsertView) { title = "Neues Kreditinstitut"; }
            else if (uc is BankUpdateView) { title = "Kreditinstitut bearbeiten"; }
            else if (uc is DokumentInsertView) { title = "Dokument bearbeiten"; }
            else if(uc is DokumentUpdateView) { title = "Neues Dokument"; }
            else if (uc is EinnahmeInsertView) { title = "Neue Einnahme"; }
            else if (uc is EinnahmeUpdateView) { title = "Einnahme bearbeiten"; }
            else if (uc is EinstellungenView) { title = "Einstellungen - neue Kategorien zufügen"; }
            else if (uc is ErstattungInsertView) {title = "Neue Erstattung"; }
            else if (uc is ErstattungUpdateView) {title = "Erstattung bearbeiten"; }
            else if (uc is ForderungInsertView) { title= "Neue Forderung"; }
            else if (uc is ForderungUpdateView) { title = "Forderung bearbeiten"; }
            else if (uc is KontaktInsertView) { title = "Neuer Kontakt"; }
            else if (uc is KontaktUpdateView) { title = "Kontakt bearbeiten"; }
            else if (uc is KontoInsertView) { title = "NeueBankverbindung"; }
            else if (uc is KontoUpdateView) { title = "Bankverbindung bearbeiten"; }
            else if (uc is LeerstandView) { title = "Leerstände"; }
            else if (uc is MieteinheitInsertView) { title = "Neue Mieteinheit"; }
            else if (uc is MieteinheitUpdateView) { title = "Mieteinheit bearbeiten"; }
            else if (uc is ObjektInsertView) {  title = "Neues Objekt"; }
            else if (uc is ObjektUpdateView) {  title = "Objekt bearbeiten"; }
            else if (uc is VertragInsertView) { title = "Neuer Vertrag"; }
            else if(uc is VertragUpdateView) { title = "Vertrag bearbeiten"; }
            else title = "neues Fenster";
            return title;
        }



        #endregion
        #region Methods



        #endregion
    }
}
