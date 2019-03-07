using ImmoLib;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImmoApp.ViewModel
{

    public class ForderungListeViewModel : ObservableObject, IPageViewModel
    {
        public string Name
        {
            get
            {
                return "Forderungen";
            }
        }

        private IEnumerable<vwForderungen> _forderungsListe;
        public IEnumerable<vwForderungen> ForderungsListe
        {
            get { return _forderungsListe; }
            private set { this.OnPropertyChanged(); }
        }
       
       
        public static IEnumerable<vwForderungen> GetForderungen()
        {
            using (immoEntities context = new immoEntities())
            {
                var query = context.vwForderungens.ToList();
                return query;
            }
        }
        public ForderungListeViewModel()
        {
           
            _forderungsListe = GetForderungen();
                      
        }
       
    }
}
