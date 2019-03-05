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
        private List<vwBankverbindung> _kontenListe = new List<vwBankverbindung>();
        public List<vwBankverbindung>KontenListe
        {
            get { return _kontenListe; }
            private set { OnPropertyChanged("KontenListe"); }
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
        public List<string> SortierkriterienListeFüllen()
        {
            CmbSort = new List<string>();
            CmbSort.Add("Inhaber");
            CmbSort.Add("IBAN");
            CmbSort.Add("Bank");
            return CmbSort;
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
 CmbSort = SortierkriterienListeFüllen();
            _kontenListe = GetKonten();

            SortKrit = "Inhaber";
        }
    }
}

    