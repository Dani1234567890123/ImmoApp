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


        private List<vwVerträge> _vertragsListe = new List<vwVerträge>();
        public List<vwVerträge> VertragsListe
        {
            get { return _vertragsListe; }
            private set { OnPropertyChanged("VertragsListe"); }
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
        private string _filterKrit;
        public string FilterKrit
        {
            get { return _filterKrit; }
            set
            {
                _filterKrit = value;
                OnPropertyChanged("FilterKrit");
            }
        }
        private List<string> _cmbFilter = new List<string>();
        public List<string> CmbFilter
        {
            get { return _cmbFilter; }
            private set { OnPropertyChanged("CmbFilter"); }
        }
        public List<string> SortierkriterienListeFüllen()
        {
            CmbSort = new List<string>();
            CmbSort.Add("Vertragsnr");
            CmbSort.Add("Objekt");
            CmbSort.Add("Mieteinheit");
            CmbSort.Add("Mieter");
            CmbSort.Add("Vermieter");
            CmbSort.Add("Beginn");
            CmbSort.Add("Ende");
            CmbSort.Add("Aktiv");
            CmbSort.Add("Beendet");
            return CmbSort;
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
            CmbSort = SortierkriterienListeFüllen();
            _vertragsListe = GetVerträge();
            CmbFilter.Add("");
            CmbFilter.Add("Aktiv");
            CmbFilter.Add("Beendet");
            SortKrit = "Vertragsnr";
        }
    }
}
