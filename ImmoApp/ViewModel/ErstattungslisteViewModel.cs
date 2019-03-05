using ImmoLib;
using ImmoLib.Locator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImmoApp.ViewModel
{
    [LocatorAttribute("Erstattungen")]
    public class ErstattungslisteViewModel : ObservableObject, IPageViewModel
    {
        public string Name
        {
            get
            {
                return "Erstattungen";
            }
        }
       private List<vwErstattungen> _erstattungsListe = new List<vwErstattungen>();
        public List<vwErstattungen> Erstattungsliste
        {
            get { return _erstattungsListe; }
            private set { OnPropertyChanged("Erstattungsliste"); }
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
            CmbSort.Add("Erstattungsnr");
            CmbSort.Add("Mietvertrag");
            CmbSort.Add("Person");
            CmbSort.Add("Betrag");
            CmbSort.Add("Grund");
            CmbSort.Add("Erledigt");
            CmbSort.Add("Offen");
            CmbSort.Add("Zahlungsdatum");
            return CmbSort;
        }
        public static List<vwErstattungen> GetErstattungen()
        {
            using (immoEntities context = new immoEntities())
            {
                var query = context.vwErstattungens.ToList();
                return query;
            }
        }
        public ErstattungslisteViewModel()
        {
            CmbSort = SortierkriterienListeFüllen();
            _erstattungsListe = GetErstattungen();
            FilterKrit = "";
            CmbFilter.Add("");
            CmbFilter.Add("Offen");
            CmbFilter.Add("Erledigt");
            SortKrit = "Erstattungsnr";
        }
    }
}