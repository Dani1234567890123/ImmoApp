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
          
        }
    }
}
