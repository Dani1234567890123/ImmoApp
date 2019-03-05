using ImmoLib;
using ImmoLib.Locator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImmoApp.ViewModel
{
    [LocatorAttribute("Objekte")]
    public class ObjektListeViewModel : ObservableObject, IPageViewModel
    {
        public string Name
        {
            get
            {
                return "Objekte";
            }
        }

        private IEnumerable<vwObjekte> _objektListe;
        public IEnumerable<vwObjekte> ObjektListe
        {
            get { return _objektListe; }
            private set { OnPropertyChanged("ObjektListe"); }
        }
        
       
        
        public static List<vwObjekte> GetObjekte()
        {
            using (immoEntities context = new immoEntities())
            {
                var query = context.vwObjektes.ToList();
                return query;
            }
        }
        public ObjektListeViewModel()
        {
           
            _objektListe = GetObjekte();

          
        }
    }
}

