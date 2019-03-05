using ImmoLib;
using ImmoLib.Locator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImmoApp.ViewModel
{
    [LocatorAttribute("Mieteinheiten")]
    public class MieteinheitListeViewModel : ObservableObject, IPageViewModel
    {
        public string Name
        {
            get
            {
                return "Mieteinheiten";
            }
        }

        private List<vwMieteinheiten> _einheitenListe = new List<vwMieteinheiten>();
        public List<vwMieteinheiten> EinheitenListe
        {
            get { return _einheitenListe; }
            private set { OnPropertyChanged("EinheitenListe"); }
        }
        private string _sortKrit;
        public string SortKrit
        {
            get { return _sortKrit; }
            set
            {
                _sortKrit = value;
                OnPropertyChanged("SortKrit");
            }
        }
        private List<string> _cmbSort = new List<string>();
        public List<string> CmbSort
        {
            get { return _cmbSort; }
            private set
            { OnPropertyChanged("CmbSort"); }
        }
        public List<string> SortierkriterienListeFüllen()
        {
            CmbSort = new List<string>();
            CmbSort.Add("MieteinheitNr");
            CmbSort.Add("Bezeichnung");
            CmbSort.Add("Objektnr");
            CmbSort.Add("Objekt");
            CmbSort.Add("Mietvertrag");
            CmbSort.Add("Mieter");
            CmbSort.Add("Vermietet");
            CmbSort.Add("Leerstehend");
            return CmbSort;
        }
        public static List<vwMieteinheiten> GetEinheiten()
        {
            using (immoEntities context = new immoEntities())
            {
                var query = context.vwMieteinheitens.ToList();
                return query;
            }
        }
        public MieteinheitListeViewModel()
        {
            CmbSort = SortierkriterienListeFüllen();
            _einheitenListe = GetEinheiten();

            SortKrit = "MieteinheitNr";
        }
    }
}
