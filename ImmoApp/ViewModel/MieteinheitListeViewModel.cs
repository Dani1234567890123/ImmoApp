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
            private set { this.OnPropertyChanged(); }
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
           
        }
    }
}
