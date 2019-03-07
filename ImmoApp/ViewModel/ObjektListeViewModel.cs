using ImmoLib;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImmoApp.ViewModel
{

    public class ObjektListeViewModel : ObservableObject, IPageViewModel
    {
        public string Name
        {
            get
            {
                return "Objekte";
            }
        }
        private vwObjekte _currentItem = new vwObjekte();
        public vwObjekte CurrentItem
        {
            get { return _currentItem; }
            set
            {
                if (_currentItem != value)
                    _currentItem = value;
                this.OnPropertyChanged();
            }
        }
         

        private IEnumerable<vwObjekte> _objektListe;
        public IEnumerable<vwObjekte> ObjektListe
        {
            get { return _objektListe; }
            private set { this.OnPropertyChanged(); }
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

