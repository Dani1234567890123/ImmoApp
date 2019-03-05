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
        public static List<vwVorlagen> GetVorlagen()
        {
            using (immoEntities context = new immoEntities())
            {
                var query = context.vwVorlagens.ToList();
                return query;
            }
        }
        public VorlageListeViewModel()
        {
            CmbSort = SortierkriterienListeFüllen();
            _vorlagenListe = GetVorlagen();

            SortKrit = "Dokumentennr";
        }
    }
}
