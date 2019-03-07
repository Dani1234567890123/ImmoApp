
using ImmoLib;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImmoApp.ViewModel
{

    public class EinstellungenViewModel : ObservableObject, IPageViewModel
    {
        public string Name
        {
            get
            {
                return "Einstellungen"; ;
            }
        }
        private IEnumerable<string> _kategorieListe;
        public IEnumerable<string> KategorieListe
        {
            get { return _kategorieListe; }
            private set { this.OnPropertyChanged(); }
        }
        private IEnumerable<string> _zahlungskategorieListe ;
        public IEnumerable<string> ZahlungsKategorieListe
        {
            get { return _zahlungskategorieListe; }
            private set { this.OnPropertyChanged(); }
        }
        private IEnumerable<string> _anredeListe ;
        public IEnumerable<string> AnredeListe
        {
            get { return _anredeListe; }
            private set { this.OnPropertyChanged(); }
        }
        private IEnumerable<string> _dokumentenKategorieListe;
        public IEnumerable<string> DokumentenKategorieListe
        {
            get { return _dokumentenKategorieListe; }
            private set { this.OnPropertyChanged(); }
        }

        private void GetKategorien()
        {
            using (immoEntities context = new immoEntities())
            {
                var liste = (from p in context.kategories select p.bezeichnung);
              
                    KategorieListe = liste; 
               
            }
        }
        private void GetZahlungsKategorien()
        {
            using (immoEntities context = new immoEntities())
            {
                var liste = (from p in context.zahlungskategories select p.kategorie);
                
                    ZahlungsKategorieListe= liste;
               
            }
        }
        private void GetAnredeKategorien()
        {
            using (immoEntities context = new immoEntities())
            {
                var liste = (from p in context.anredes select p.text);
                
                    AnredeListe = liste;
               
            }
        }
        private void GetDokumentenKategorien()
        {
            using (immoEntities context = new immoEntities())
            {
                var liste = (from p in context.dokumentenkategories select p.kategorie);
                
                    DokumentenKategorieListe=liste;
                
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
