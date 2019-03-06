using ImmoLib;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImmoApp.ViewModel
{

    public class KontaktListeViewModel : ObservableObject, IPageViewModel
    {
        public string Name
        {
            get
            {
                return "Kontakte";
            }
        }
        private IEnumerable<vwKontakte> _kontaktListe;
        public IEnumerable<vwKontakte> KontaktListe
        {
            get { return _kontaktListe; }
            private set { OnPropertyChanged("KontaktListe"); }
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

      
        public static List<vwKontakte> GetKontakte()
        {
            using (immoEntities context = new immoEntities())
            {
                var query = context.vwKontaktes.ToList();
                return query;
            }
        }
        private void GetKontaktKategorien()
        {
            using (immoEntities context = new immoEntities())
            {
                var liste = (from p in context.kategories select p.bezeichnung);
                foreach (var item in liste)
                {
                    CmbFilter.Add(item.ToString());
                }
            }
        }
        public KontaktListeViewModel()
        {
          
            _kontaktListe = GetKontakte();
            FilterKrit = "";
            CmbFilter.Add("");
            GetKontaktKategorien();
            CmbFilter.Add("Offen");
            CmbFilter.Add("Erledigt");
          
        }
    }
}
