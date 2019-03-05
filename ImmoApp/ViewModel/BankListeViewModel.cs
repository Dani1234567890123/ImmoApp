using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImmoLib;

namespace ImmoApp.ViewModel
{
    public class BankListeViewModel : ObservableObject, IPageViewModel
    {
        public string Name
        {
            get
            {
                return "Banken";
            }
        }
        private IEnumerable<vwBanken> _bankListe;
        public IEnumerable<vwBanken> BankListe
        {
            get { return _bankListe; }
            private set
            {
                OnPropertyChanged("BankListe");
            }
        }
        
       

        public BankListeViewModel()
        {
            
            _bankListe = GetBanken();
            
        }

        private IEnumerable<vwBanken> GetBanken()
        {
            using (immoEntities context = new immoEntities())
            {
                var query = context.vwBankens.ToList();
                return query;

            }
        }

            }
}
