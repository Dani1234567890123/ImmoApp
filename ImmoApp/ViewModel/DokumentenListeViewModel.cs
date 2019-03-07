using ImmoLib;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImmoApp.ViewModel
{

    public class DokumentenListeViewModel : ObservableObject, IPageViewModel
    {
        private IEnumerable<vwDokumente> _dokListe;
       
        public string Name
        {
            get
            {
                return "alle Dokumente";
            }
        }
      


        public IEnumerable<vwDokumente> DokListe
        {
            get { return _dokListe; }
            private set { this.OnPropertyChanged(); }
        }
           
        

        public DokumentenListeViewModel()
        {
           
            _dokListe = GetDoks();
            _dokListe.OrderBy(p => p.titel);
          
                }
          
       
        private IEnumerable<vwDokumente> GetDoks()
        {
            

            using (immoEntities context = new immoEntities())
            {

                var query = context.vwDokumentes.ToList();
                return query;
            }
        }

           }
}
