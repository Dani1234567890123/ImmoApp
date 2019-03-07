using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImmoLib;

namespace ImmoApp.ViewModel
{
    class KontenListeViewModel : ObservableObject, IPageViewModel
    {
        public string Name
        {
            get
            {
                return "alle Konten";
            }
        }
        private IEnumerable<vwBankverbindung> _kontenListe;
        public IEnumerable<vwBankverbindung>KontenListe
        {
            get { return _kontenListe; }
            private set { this.OnPropertyChanged(); }
        }
       
       
        public static List<vwBankverbindung> GetKonten()
        {
            using (immoEntities context = new immoEntities())
            {
                var query = context.vwBankverbindungs.ToList();
                return query;
            }
        }
        public KontenListeViewModel()
        {
 
            _kontenListe = GetKonten();

            
        }
    }
}

    