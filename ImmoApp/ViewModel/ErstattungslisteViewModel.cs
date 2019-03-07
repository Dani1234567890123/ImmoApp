using ImmoLib;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImmoApp.ViewModel
{

    public class ErstattungslisteViewModel : ObservableObject, IPageViewModel
    {
        public string Name
        {
            get
            {
                return "Erstattungen";
            }
        }
       private IEnumerable<vwErstattungen> _erstattungsListe;
        public IEnumerable<vwErstattungen> Erstattungsliste
        {
            get { return _erstattungsListe; }
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

        
        public static List<vwErstattungen> GetErstattungen()
        {
            using (immoEntities context = new immoEntities())
            {
                var query = context.vwErstattungens.ToList();
                return query;
            }
        }
        public ErstattungslisteViewModel()
        {
           
            _erstattungsListe = GetErstattungen();
            FilterKrit = "";
            CmbFilter.Add("");
            CmbFilter.Add("Offen");
            CmbFilter.Add("Erledigt");
          
        }
    }
}