using ImmoLib;
using ImmoLib.Locator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImmoApp.ViewModel
{
    [LocatorAttribute("Vorlagen")]
    public class VorlageListeViewModel : ObservableObject, IPageViewModel
    {
        public string Name
        {
            get
            {
                return "Vorlagen";
            }
        }

        private List<vwVorlagen> _vorlagenListe = new List<vwVorlagen>();
        public List<vwVorlagen> VorlagenListe
        {
            get { return _vorlagenListe; }
            private set { OnPropertyChanged("VorlagenListe"); }
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
            CmbSort.Add("Dokumentennr");
            CmbSort.Add("Kategorie");
            CmbSort.Add("Titel");
            return CmbSort;
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

        public static List<vwVorlagen> GetVorlagen()
        {
            using (immoEntities context = new immoEntities())
            {
                var query = context.vwVorlagens.ToList();
                return query;
            }
        }
        private void GetDokKategorien()
        {
            using (immoEntities context = new immoEntities())
            {
                var liste = (from p in context.dokumentenkategories select p.kategorie);
                foreach (var item in liste)
                {
                    CmbFilter.Add(item.ToString());
                }
            }
        }
        public VorlageListeViewModel()
        {
            CmbSort = SortierkriterienListeFüllen();
            _vorlagenListe = GetVorlagen();
            FilterKrit = "";
            CmbFilter.Add("");
            GetDokKategorien();
            SortKrit = "Dokumentennr";
        }
    }
}
