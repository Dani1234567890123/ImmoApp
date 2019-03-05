﻿using ImmoLib;
using ImmoLib.Locator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImmoApp.ViewModel
{
    [LocatorAttribute("Einnahmen")]
    public class EinnahmenListeViewModel : ObservableObject, IPageViewModel
    {
        private List<vwEinnahman> _einnahmenListe = new List<vwEinnahman>();
        private string _sortKrit;

        public string Name
        {
            get
            {
                return "Einnahmen";
            }
        }
        public string SortKrit
        {
            get { return _sortKrit; }
            set
            {
                _sortKrit = value;
                OnPropertyChanged("SortKrit");
            }
        }
        public List<vwEinnahman> EinnahmenListe
        {
            get { return _einnahmenListe; }
            private set { OnPropertyChanged("EinnahmenListe"); }
        }
        private List<string> _cmbSort = new List<string>();
        public List<string> CmbSort
        {
            get { return _cmbSort; }
            private set
            { OnPropertyChanged("CmbSort"); }
        }
        public EinnahmenListeViewModel()
        {
            CmbSort = SortierkriterienListeFüllen();
            _einnahmenListe = GetEinnahmen();

            SortKrit = "Einnahmenr";
        }

        private List<vwEinnahman> GetEinnahmen()
        {
            using (immoEntities context = new immoEntities())
            {
                var query = context.vwEinnahmen.ToList();
                return query;
            }
        }

        private List<string> SortierkriterienListeFüllen()
        {
            CmbSort = new List<string>();
            CmbSort.Add("Einnahmenr");
            CmbSort.Add("Kategorie");
            CmbSort.Add("Bezeichnung");
            CmbSort.Add("Betrag");
            CmbSort.Add("Datum");
            return CmbSort;
        }
    }
}
