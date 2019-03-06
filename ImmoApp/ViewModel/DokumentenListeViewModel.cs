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
            private set { OnPropertyChanged("DokListe"); }
        }
       
        private string _filterKrit;
        public string FilterKrit
        {
            get { return _filterKrit; }
            set
            {
                _filterKrit = value;
                OnPropertyChanged("FilterKrit");
            }
        }
        private List<string> _cmbFilter = new List<string>();
        public List<string> CmbFilter
        {
            get { return _cmbFilter; }
            private set { OnPropertyChanged("CmbFilter");  }
        }




        public DokumentenListeViewModel()
        {
           
            _dokListe = GetDoks();
            _dokListe.OrderBy(p => p.titel);

           
            FilterKrit = "";
            CmbFilter.Add("");
            GetDokKategorien();

        }
          
        private void GetDokKategorien()
        {
            using (immoEntities context = new immoEntities())
            {
                var liste = (from p in context.dokumentenkategories select p.kategorie);
                foreach (var item in liste)
                {
                    CmbFilter.Add(item.ToString());
                }
            }
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
