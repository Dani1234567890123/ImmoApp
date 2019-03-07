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
            private set { this.OnPropertyChanged(); }
        }
        
       
        public EinnahmenListeViewModel()
        {
           
            _einnahmenListe = GetEinnahmen();
           
            
        }

        private List<vwEinnahman> GetEinnahmen()
        {
            using (immoEntities context = new immoEntities())
            {
                var query = context.vwEinnahmen.ToList();
                return query;
            }
        }
       
          }
}
