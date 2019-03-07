using ImmoLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace ImmoApp.ViewModel
{
    public class StartViewModel : ObservableObject
    {
        #region Fields

        private ICommand _changePageCommand;

        private IPageViewModel _currentPageViewModel;
        private List<IPageViewModel> _pageViewModels;
        public DokumentUpdateViewModel duv = new DokumentUpdateViewModel();

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
        }

        #region Naviagationsbuttons + Methoden

        public ICommand ChangePageCommand
        {
            get
            {
                if (_changePageCommand == null)
                {
                    _changePageCommand = new RelayCommand<IPageViewModel>(
                        p => ChangeViewModel(p),
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
       



        #endregion
        #region Methods



        #endregion
    }
}
