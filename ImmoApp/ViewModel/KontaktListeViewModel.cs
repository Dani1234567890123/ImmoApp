using ImmoLib;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImmoApp.ViewModel
{

    public class KontaktListeViewModel : ObservableObject, IPageViewModel
    {
        public string Name
        {
            get
            {
                return "Kontakte";
            }
        }
        private IEnumerable<vwKontakte> _kontaktListe;
        public IEnumerable<vwKontakte> KontaktListe
        {
            get { return _kontaktListe; }
            private set { this.OnPropertyChanged(); }
        }
     
        public static List<vwKontakte> GetKontakte()
        {
            using (immoEntities context = new immoEntities())
            {
                var query = context.vwKontaktes.ToList();
                return query;
            }
        }
      
        public KontaktListeViewModel()
        {
          
            _kontaktListe = GetKontakte();
           
        }
    }
}
