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
                     
        }
    }
}