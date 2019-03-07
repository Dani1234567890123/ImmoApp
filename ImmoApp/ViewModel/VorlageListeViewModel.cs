using ImmoLib;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImmoApp.ViewModel
{

    public class VorlageListeViewModel : ObservableObject, IPageViewModel
    {
        public string Name
        {
            get
            {
                return "Vorlagen";
            }
        }

        private IEnumerable<vwVorlagen> _vorlagenListe ;
        public IEnumerable<vwVorlagen> VorlagenListe
        {
            get { return _vorlagenListe; }
            private set { this.OnPropertyChanged(); }
        }
        
        public static List<vwVorlagen> GetVorlagen()
        {
            using (immoEntities context = new immoEntities())
            {
                var query = context.vwVorlagens.ToList();
                return query;
            }
        }
      
        public VorlageListeViewModel()
        {
           
            _vorlagenListe = GetVorlagen();
           
        }
    }
}
