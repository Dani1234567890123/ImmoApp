using ImmoLib;
using ImmoLib.Locator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImmoApp.ViewModel
{
    [LocatorAttribute("alle Dokumente")]
    public class DokumentenListeViewModel : ObservableObject, IPageViewModel
    {
        private List<vwDokumente> _dokListe = new List<vwDokumente>();
        private string _sortKrit;
        public string Name
        {
            get
            {
                return "alle Dokumente";
            }
        }
        public string SortKrit
        {
            get { return _sortKrit; }
            set
            {
                _sortKrit = value;
                OnPropertyChanged("SortKrit");
            }
        }
        public List<vwDokumente> DokListe
        {
            get { return _dokListe; }
            private set { OnPropertyChanged("DokListe"); }
        }
        private List<string> _cmbSort = new List<string>();
        public List<string> CmbSort
        {
            get { return _cmbSort; }
            private set
            { OnPropertyChanged("CmbSort"); }
        }
        public DokumentenListeViewModel()
        {
            CmbSort = SortierkriterienListeFüllen();
            _dokListe = GetDoks();

            SortKrit = "Dokumentennr";
        }

        private List<vwDokumente> GetDoks()
        {
            using (immoEntities context = new immoEntities())
            {
                var query = context.vwDokumentes.ToList();
                return query;
            }
        }

        private List<string> SortierkriterienListeFüllen()
        {
            CmbSort = new List<string>();
            CmbSort.Add("Dokumentennr");
            CmbSort.Add("Kategorie");
            CmbSort.Add("DateiName");
            CmbSort.Add("Person");
            CmbSort.Add("Objekt");
            CmbSort.Add("Mieteinheit");
            CmbSort.Add("Mietvertrag");
            return CmbSort;
        }
    }
}
