using ImmoLib;
using ImmoLib.Locator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImmoApp.ViewModel
{
    [LocatorAttribute("Objekte")]
    public class ObjektListeViewModel : ObservableObject, IPageViewModel
    {
        public string Name
        {
            get
            {
                return "Objekte";
            }
        }

        private List<vwObjekte> _objektListe = new List<vwObjekte>();
        public List<vwObjekte> ObjektListe
        {
            get { return _objektListe; }
            private set { OnPropertyChanged("ObjektListe"); }
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
            CmbSort.Add("Objektnummer");
            CmbSort.Add("Straße");
            CmbSort.Add("Ort");
            CmbSort.Add("Vermieter");
            CmbSort.Add("Baujahr");
            return CmbSort;
        }
        public static List<vwObjekte> GetObjekte()
        {
            using (immoEntities context = new immoEntities())
            {
                var query = context.vwObjektes.ToList();
                return query;
            }
        }
        public ObjektListeViewModel()
        {
            CmbSort = SortierkriterienListeFüllen();
            _objektListe = GetObjekte();

            SortKrit = "Objektnummer";
        }
    }
}

