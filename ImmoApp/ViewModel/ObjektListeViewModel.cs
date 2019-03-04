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
        private List<vwObjekte> _objektListe = new List<vwObjekte>();
        private string _sortKrit;

        public string Name
        {
            get
            {
                return "Objekte";
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
        public List<vwObjekte> ObjektListe
        {
            get { return _objektListe; }
            private set { }
        }

        public List<string> cmbSort { get; private set; }



        public ObjektListeViewModel()
        {
            cmbSort = SortierkriterienListeFüllen();
            _objektListe = GetObjekte();
            
            SortKrit = "Objektnummer";

        }

        public List<string> SortierkriterienListeFüllen()
        {
            cmbSort = new List<string>();
            cmbSort.Add("Objektnummer");
            cmbSort.Add("Straße");
            cmbSort.Add("Ort");
            cmbSort.Add("Vermieter");
            cmbSort.Add("Baujahr");
            return cmbSort;
        }

        public static List<vwObjekte> GetObjekte()
        {
            using (immoEntities context = new immoEntities())
            {
                var query = context.vwObjektes.ToList();
                return query;

            }
        }
    }
}
