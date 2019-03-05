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

        private IEnumerable<vwForderungen> _forderungsListe;
        public IEnumerable<vwForderungen> ForderungsListe
        {
            get { return _forderungsListe; }
            private set { OnPropertyChanged("ForderungsListe"); }
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


      
        public static IEnumerable<vwForderungen> GetForderungen()
        {
            using (immoEntities context = new immoEntities())
            {
                var query = context.vwForderungens.ToList();
                return query;
            }
        }
        public ForderungListeViewModel()
        {
           
            _forderungsListe = GetForderungen();
            FilterKrit = "";
            CmbFilter.Add("");
            GetZahlungsKategorien();
            CmbFilter.Add("Offen");
            CmbFilter.Add("Erledigt");
           
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
