using ImmoLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ImmoApp.ViewModel
{
    public class StartViewModel : ObservableObject
    { 
   #region Fields

    private ICommand _changePageCommand;

    private IPageViewModel _currentPageViewModel;
    private List<IPageViewModel> _pageViewModels;

    #endregion

    public StartViewModel()
    {
        // Add available pages
        PageViewModels.Add(new StartPageViewModel());
        PageViewModels.Add(new DokumentenListeViewModel());
            PageViewModels.Add(new DokumentInsertViewModel());
            PageViewModels.Add(new DokumentUpdateViewModel());
            PageViewModels.Add(new EinnahmeInsertViewModel());
            PageViewModels.Add(new EinnahmenListeViewModel());
            PageViewModels.Add(new EinnahmeUpdateViewModel());
            PageViewModels.Add(new EinstellungenViewModel());
            PageViewModels.Add(new ErstattungInsertViewModel());
            PageViewModels.Add(new ErstattungslisteViewModel());
            PageViewModels.Add(new ErstattungUpdateViewModel());
            PageViewModels.Add(new ForderungInsertViewModel());
            PageViewModels.Add(new ForderungListeViewModel());
            PageViewModels.Add(new ForderungUpdateViewModel());
            PageViewModels.Add(new KontaktInsertViewModel());
            PageViewModels.Add(new KontaktListeViewModel());
            PageViewModels.Add(new KontaktUpdateViewModel());
            PageViewModels.Add(new MieteinheitInsertViewModel());
            PageViewModels.Add(new MieteinheitListeViewModel());
            PageViewModels.Add(new MieteinheitUpdateViewModel());
            PageViewModels.Add(new ObjektInsertViewModel());
            PageViewModels.Add(new ObjektListeViewModel());
            PageViewModels.Add(new ObjektUpdateViewModel());
            PageViewModels.Add(new VertragInsertViewModel());
            PageViewModels.Add(new VertragslisteViewModel());
            PageViewModels.Add(new VertragUpdateViewModel());
            PageViewModels.Add(new VorlageListeViewModel());

        // Set starting page
        CurrentPageViewModel = PageViewModels[0];
    }

    #region Properties / Commands

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
                OnPropertyChanged("CurrentPageViewModel");
            }
        }
    }

    #endregion

    #region Methods

    private void ChangeViewModel(IPageViewModel viewModel)
    {
        if (!PageViewModels.Contains(viewModel))
            PageViewModels.Add(viewModel);

        CurrentPageViewModel = PageViewModels
            .FirstOrDefault(vm => vm == viewModel);
    }

    #endregion
}
}
