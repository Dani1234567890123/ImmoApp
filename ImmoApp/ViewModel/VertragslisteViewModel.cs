using ImmoLib;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImmoApp.ViewModel
{
    
    public class VertragslisteViewModel : ObservableObject, IPageViewModel
    {
        public string Name
        {
            get
            {
                return "Mietverträge";
            }
        }


        private IEnumerable<vwVerträge> _vertragsListe;
        public IEnumerable<vwVerträge> VertragsListe
        {
            get { return _vertragsListe; }
            private set { OnPropertyChanged("VertragsListe"); }
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
       
        public static List<vwVerträge> GetVerträge()
        {
            using (immoEntities context = new immoEntities())
            {
                var query = context.vwVerträge.ToList();
                return query;
            }
        }
        public VertragslisteViewModel()
        {
           
            _vertragsListe = GetVerträge();
            CmbFilter.Add("");
            CmbFilter.Add("Aktiv");
            CmbFilter.Add("Beendet");
          
        }
    }
}
