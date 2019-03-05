﻿using ImmoLib;
using ImmoLib.Locator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImmoApp.ViewModel
{
    [LocatorAttribute("Vorlagen")]
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
            private set { OnPropertyChanged("VorlagenListe"); }
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
            private set { OnPropertyChanged("CmbFilter"); }
        }

        public static List<vwVorlagen> GetVorlagen()
        {
            using (immoEntities context = new immoEntities())
            {
                var query = context.vwVorlagens.ToList();
                return query;
            }
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
        public VorlageListeViewModel()
        {
           
            _vorlagenListe = GetVorlagen();
            FilterKrit = "";
            CmbFilter.Add("");
            GetDokKategorien();
           
        }
    }
}
