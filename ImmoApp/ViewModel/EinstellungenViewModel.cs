
using ImmoLib;
using ImmoLib.Locator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImmoApp.ViewModel
{
    [LocatorAttribute("Einstellungen")]
    public class EinstellungenViewModel : ObservableObject, IPageViewModel
    {
        public string Name
        {
            get
            {
                return "Einstellungen"; ;
            }
        }
        private List<string> _kategorieListe = new List<string>();
        public List<string> KategorieListe
        {
            get { return _kategorieListe; }
            private set { OnPropertyChanged("KategorieListe"); }
        }
        private List<string> _zahlungskategorieListe = new List<string>();
        public List<string> ZahlungsKategorieListe
        {
            get { return _zahlungskategorieListe; }
            private set { OnPropertyChanged("ZahlungsKategorieListe"); }
        }
        private List<string> _anredeListe = new List<string>();
        public List<string> AnredeListe
        {
            get { return _anredeListe; }
            private set { OnPropertyChanged("AnredeListe"); }
        }
        private List<string> _dokumentenKategorieListe = new List<string>();
        public List<string> DokumentenKategorieListe
        {
            get { return _dokumentenKategorieListe; }
            private set { OnPropertyChanged("DokumentenKategorieListe"); }
        }

        private void GetKategorien()
        {
            using (immoEntities context = new immoEntities())
            {
                var liste = (from p in context.kategories select p.bezeichnung);
                foreach (var item in liste)
                {
                    KategorieListe.Add(item.ToString());
                }
            }
        }
        private void GetZahlungsKategorien()
        {
            using (immoEntities context = new immoEntities())
            {
                var liste = (from p in context.zahlungskategories select p.kategorie);
                foreach (var item in liste)
                {
                    ZahlungsKategorieListe.Add(item.ToString());
                }
            }
        }
        private void GetAnredeKategorien()
        {
            using (immoEntities context = new immoEntities())
            {
                var liste = (from p in context.anredes select p.text);
                foreach (var item in liste)
                {
                    AnredeListe.Add(item.ToString());
                }
            }
        }
        private void GetDokumentenKategorien()
        {
            using (immoEntities context = new immoEntities())
            {
                var liste = (from p in context.dokumentenkategories select p.kategorie);
                foreach (var item in liste)
                {
                    DokumentenKategorieListe.Add(item.ToString());
                }
            }
        }
        public EinstellungenViewModel()
        {
            GetAnredeKategorien();
            GetDokumentenKategorien();
            GetKategorien();
            GetZahlungsKategorien();
        }
    }
}
