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
        public static int übergabewert;
        public string Name
        {
            get
            {
                return "Mietverträge";
            }
        }
        private vwVerträge _selectedVertrag;            

        public vwVerträge SelectedVertrag
        {
            get { return _selectedVertrag; }
            set {
                if ( _selectedVertrag != value)
                    _selectedVertrag = value;
                übergabewert = _selectedVertrag.Vertragsnr;
                this.OnPropertyChanged();
            }
        }


        private IEnumerable<vwVerträge> _vertragsListe;
        public IEnumerable<vwVerträge> VertragsListe
        {
            get { return _vertragsListe; }
            private set { this.OnPropertyChanged(); }
        }
       
        private string _filterKrit;
        public string FilterKrit
        {
            get { return _filterKrit; }
            set
            {
                _filterKrit = value;
                this.OnPropertyChanged();
            }
        }
        private List<string> _cmbFilter = new List<string>();
        public List<string> CmbFilter
        {
            get { return _cmbFilter; }
            private set { this.OnPropertyChanged(); }
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
