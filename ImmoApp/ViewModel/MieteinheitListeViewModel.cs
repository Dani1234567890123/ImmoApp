using ImmoLib;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImmoApp.ViewModel
{
   
    public class MieteinheitListeViewModel : ObservableObject, IPageViewModel
    {
        public string Name
        {
            get
            {
                return "Mieteinheiten";
            }
        }

        private IEnumerable<vwMieteinheiten> _einheitenListe ;
        public IEnumerable<vwMieteinheiten> EinheitenListe
        {
            get { return _einheitenListe; }
            private set { OnPropertyChanged("EinheitenListe"); }
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

      
        public static List<vwMieteinheiten> GetEinheiten()
        {
            using (immoEntities context = new immoEntities())
            {
                var query = context.vwMieteinheitens.ToList();
                return query;
            }
        }
        public MieteinheitListeViewModel()
        {
           
            _einheitenListe = GetEinheiten();
            CmbFilter.Add("");
            CmbFilter.Add("Vermietet");
            CmbFilter.Add("Leerstehend");
            CmbFilter.Add("Aktiv");
            CmbFilter.Add("Inaktiv");
          
        }
    }
}
