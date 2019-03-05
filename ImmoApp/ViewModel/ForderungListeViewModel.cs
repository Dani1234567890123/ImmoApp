using ImmoLib;
using ImmoLib.Locator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImmoApp.ViewModel
{
    [LocatorAttribute("Forderungen")]
    public class ForderungListeViewModel : ObservableObject, IPageViewModel
    {
        public string Name
        {
            get
            {
                return "Forderungen";
            }
        }

        private List<vwForderungen> _forderungsListe = new List<vwForderungen>();
        public List<vwForderungen> ForderungsListe
        {
            get { return _forderungsListe; }
            private set { OnPropertyChanged("ForderungsListe"); }
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
            CmbSort.Add("Forderungsnr");
            CmbSort.Add("Kategorie");
            CmbSort.Add("Fälligkeit");
            CmbSort.Add("Name");
            CmbSort.Add("Mieteinheit");
            CmbSort.Add("Betrag");
            CmbSort.Add("Offen");
            CmbSort.Add("Erledigt");
            return CmbSort;
        }
        public static List<vwForderungen> GetForderungen()
        {
            using (immoEntities context = new immoEntities())
            {
                var query = context.vwForderungens.ToList();
                return query;
            }
        }
        public ForderungListeViewModel()
        {
            CmbSort = SortierkriterienListeFüllen();
            _forderungsListe = GetForderungen();
            FilterKrit = "";
            CmbFilter.Add("");
            GetZahlungsKategorien();
            CmbFilter.Add("Offen");
            CmbFilter.Add("Erledigt");
            SortKrit = "Forderungsnr";
        }
        private void GetZahlungsKategorien()
        {
            using (immoEntities context = new immoEntities())
            {
                var liste = (from p in context.zahlungskategories select p.kategorie);
                foreach (var item in liste)
                {
                    CmbFilter.Add(item.ToString());
                }
            }
        }
    }
}
