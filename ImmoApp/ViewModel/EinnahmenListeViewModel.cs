using ImmoLib;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImmoApp.ViewModel
{

    public class EinnahmenListeViewModel : ObservableObject, IPageViewModel
    {
        private IEnumerable<vwEinnahman> _einnahmenListe;
       
        public string Name
        {
            get
            {
                return "Einnahmen";
            }
        }
     
        public IEnumerable<vwEinnahman> EinnahmenListe
        {
            get { return _einnahmenListe; }
            private set { OnPropertyChanged("EinnahmenListe"); }
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

        public EinnahmenListeViewModel()
        {
           
            _einnahmenListe = GetEinnahmen();
            FilterKrit = "";
            CmbFilter.Add("");
            GetZahlungsKategorien();
            
        }

        private List<vwEinnahman> GetEinnahmen()
        {
            using (immoEntities context = new immoEntities())
            {
                var query = context.vwEinnahmen.ToList();
                return query;
            }
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
