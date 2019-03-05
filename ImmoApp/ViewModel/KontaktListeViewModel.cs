using ImmoLib;
using ImmoLib.Locator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImmoApp.ViewModel
{
    [LocatorAttribute("Kontakte")]
    public class KontaktListeViewModel : ObservableObject, IPageViewModel
    {
        public string Name
        {
            get
            {
                return "Kontakte";
            }
        }
        private List<vwKontakte> _kontaktListe = new List<vwKontakte>();
        public List<vwKontakte> KontaktListe
        {
            get { return _kontaktListe; }
            private set { OnPropertyChanged("KontaktListe"); }
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
            CmbSort.Add("Kontaktnr");
            CmbSort.Add("Nachname");
            CmbSort.Add("Kategorie");
            CmbSort.Add("Anrede");
            CmbSort.Add("Plz");
            CmbSort.Add("Ort");
            CmbSort.Add("Geb-Datum");
            CmbSort.Add("Kreditinstitut");
            return CmbSort;
        }
        public static List<vwKontakte> GetKontakte()
        {
            using (immoEntities context = new immoEntities())
            {
                var query = context.vwKontaktes.ToList();
                return query;
            }
        }
        public KontaktListeViewModel()
        {
            CmbSort = SortierkriterienListeFüllen();
            _kontaktListe = GetKontakte();

            SortKrit = "Kontaktnr";
        }
    }
}
