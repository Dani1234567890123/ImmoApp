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
        private List<vwBanken> _bankListe = new List<vwBanken>();
        public List<vwBanken> BankListe
        {
            get { return _bankListe; }
            private set
            {
                OnPropertyChanged("BankListe");
            }
        }
        private string _sortKrit;
        public string SortKrit
        {
            get { return _sortKrit; }
            set
            {
                _sortKrit = value;
                OnPropertyChanged("SortKrit");
            }
        }
        private List<string> _cmbSort = new List<string>();
        public List<string> CmbSort
        {
            get { return _cmbSort; }
            private set
            { OnPropertyChanged("CmbSort"); }
        }

        public BankListeViewModel()
        {
            CmbSort = SortierkriterienListeFüllen();
            _bankListe = GetBanken();
            SortKrit = "Name";
        }

        private List<vwBanken> GetBanken()
        {
            using (immoEntities context = new immoEntities())
            {
                var query = context.vwBankens.ToList();
                return query;

            }
        }

        private List<string> SortierkriterienListeFüllen()
        {
            CmbSort = new List<string>();
            CmbSort.Add("Name");
            CmbSort.Add("Straße");
            CmbSort.Add("Ort");
            return CmbSort;
        }
    }
}
