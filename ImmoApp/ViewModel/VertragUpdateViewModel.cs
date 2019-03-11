using ImmoApp.View;
using ImmoLib;

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace ImmoApp.ViewModel
{


    public class VertragUpdateViewModel : ObservableObject, IPageViewModel
    {
        public string Name
        {
            get
            {
                return "Vertrag bearbeiten";
            }
        }

        #region Übergabewerte
        //ÜbergabeWert der VertragslisteViewModel-Klasse
        private mietvertrag selectedVertrag;
        //ÜbergabeWerte
        public static int ÜbergabeNotiz;
        public static int ÜbergabeDok;
        public static int ÜbergabeForderung;
        public static int ÜbergabeErstattung;
        #endregion
        #region prop Vertragsdaten
        private int _vertID;
        public int VertID
        {
            get { return _vertID; }
            private set
            {
                if (_vertID != value)
                {
                    _vertID = value;
                    this.OnPropertyChanged();
                }
            }
        }
        private int _zuEinheit;
        public int ZuEinheit
        {
            get { return _zuEinheit; }
            set
            {
                if (_zuEinheit != value)
                {
                    _zuEinheit = value;
                    this.OnPropertyChanged();
                }
            }
        }
        private int _mieterID;
        public int MieterID
        {
            get { return _mieterID; }
            set
            {
                if (_mieterID != value)
                {
                    _mieterID = value;
                    this.OnPropertyChanged();
                }
            }
        }
        private Nullable<DateTime> _vertragsdatum;
        public Nullable<DateTime> Vertragsdatum
        {
            get { return _vertragsdatum; }
            set
            {
                if (_vertragsdatum != value)
                {
                    _vertragsdatum = value;
                    this.OnPropertyChanged();
                }
            }
        }
        private DateTime _vertragsbeginn;
        public DateTime Vertragsbeginn
        {
            get { return _vertragsbeginn; }
            set
            {
                if (_vertragsbeginn != value)
                {
                    _vertragsbeginn = value;
                    this.OnPropertyChanged();
                }
            }
        }
        private Nullable<DateTime> _vertragsende;
        //falls Vertragsende nach Vertragsende geändert wird, Vertag inaktiv setzen
        public Nullable<DateTime> Vertragsende
        {
            get { return _vertragsende; }
            set
            {
                if (value < DateTime.Now)
                {
                    VertragAktiv = false;
                    if (_vertragsende != value)
                    {
                        _vertragsende = value;
                        this.OnPropertyChanged();
                    }
                }
                else if (_vertragsende != value)
                {
                    _vertragsende = value;
                    this.OnPropertyChanged();
                }

            }
        }
        private decimal _kaution;
        public decimal Kaution
        {
            get { return _kaution; }
            set
            {
                if (_kaution != value)
                {
                    _kaution = value;
                    this.OnPropertyChanged();
                }
            }
        }
        private int _kautionsraten;
        public int Kautionsraten
        {
            get { return _kautionsraten; }
            set
            {
                if (_kautionsraten != value)
                {
                    _kautionsraten = value;
                    this.OnPropertyChanged();
                }
            }
        }
        private decimal _kautionsratenHöhe;
        public decimal KautionsratenHöhe
        {
            get { return _kautionsratenHöhe; }
            private set
            {
                if (_kautionsratenHöhe != value)
                {
                    _kautionsratenHöhe = value;
                    this.OnPropertyChanged();
                }
            }
        }

        private bool _kautionBez;
        public bool KautionBez
        {
            get { return _kautionBez; }
            set
            {
                if (_kautionBez != value)
                {
                    _kautionBez = value;
                    this.OnPropertyChanged();
                }
            }
        }
        private string _kündigungsfrist;
        public string Kündigungsfrist
        {
            get { return _kündigungsfrist; }
            set
            {
                if (_kündigungsfrist != value)
                {
                    _kündigungsfrist = value;
                    this.OnPropertyChanged();
                }
            }
        }
        private bool _vertragAktiv;
        public bool VertragAktiv
        {
            get { return _vertragAktiv; }
            set
            {
                if (_vertragAktiv != value)
                {
                    _vertragAktiv = value;
                    this.OnPropertyChanged();
                }
            }
        }
        private string _objektBez;

        public string ObjektBez
        {
            get { return _objektBez; }
            set
            {
                if (_objektBez != value)
                {
                    _objektBez = value;
                    this.OnPropertyChanged();
                }
            }
        }

        private string _mieteinheitBez;

        public string MieteinheitBez
        {
            get { return _mieteinheitBez; }
            set
            {
                if (_mieteinheitBez != value)
                {
                    _mieteinheitBez = value;
                    this.OnPropertyChanged();
                }
            }
        }
        private string _mieter;

        public string Mieter
        {
            get { return _mieter; }
            set
            {
                if (_mieter != value)
                {
                    _mieter = value;
                    this.OnPropertyChanged();
                }
            }
        }

        private string _vermieter;

        public string Vermieter
        {
            get { return _vermieter; }
            set
            {
                if (_vermieter != value)
                {
                    _vermieter = value;
                    this.OnPropertyChanged();
                }
            }
        }
        #endregion
        #region prop miete
        private miete _miete;

        public miete Miete
        {
            get { return _miete; }
            set
            {
                if (_miete != value)
                {
                    _miete = value;
                    this.OnPropertyChanged();
                }
            }
        }


        private int _mietID;

        public int MietID
        {
            get { return _mietID; }
            set
            {
                if (_mietID != value)
                {
                    _mietID = value;
                    this.OnPropertyChanged();
                }
            }
        }
        private decimal _kaltmiete;

        public decimal Kaltmiete
        {
            get { return _kaltmiete; }
            set
            {
                if (_kaltmiete != value)
                {
                    //if (value == null)
                    _kaltmiete = Math.Round(value, 2);
                    this.OnPropertyChanged();
                    BruttomieteBerechnen();

                }
            }
        }

        private DateTime _gültigAb;

        public DateTime GültigAb
        {
            get { return _gültigAb; }
            set
            {
                if (_gültigAb != value)
                {
                    _gültigAb = value;
                    this.OnPropertyChanged();
                }
            }
        }
        private decimal _nk;

        public decimal NK
        {
            get { return _nk; }
            set
            {
                if (_nk != value)
                {
                    _nk = Math.Round(value, 2);
                    this.OnPropertyChanged();
                    BruttomieteBerechnen();

                }
            }
        }
        private decimal _garage;

        public decimal Garage
        {
            get { return _garage; }
            set
            {
                if (_garage != value)
                {
                    _garage = Math.Round((decimal)value, 2);
                    this.OnPropertyChanged();
                    BruttomieteBerechnen();

                }
            }
        }
        private decimal _stellplatz;

        public decimal Stellplatz
        {
            get { return _stellplatz; }
            set
            {
                if (_stellplatz != value)
                {

                    _stellplatz = Math.Round((decimal)value, 2);
                    this.OnPropertyChanged();
                    BruttomieteBerechnen();

                }
            }
        }
        private decimal _sonstMiete;

        public decimal SonstMiete
        {
            get { return _sonstMiete; }
            set
            {
                if (_sonstMiete != value)
                {
                    _sonstMiete = Math.Round((decimal)value, 2);
                    this.OnPropertyChanged();
                    BruttomieteBerechnen();

                }
            }
        }


        private decimal _bruttoMiete;

        public decimal BruttoMiete
        {
            get { return _bruttoMiete; }
            set
            {
                if (_bruttoMiete != value)
                {
                    _bruttoMiete = Math.Round(value, 2);
                    this.OnPropertyChanged();
                }
            }
        }


        #endregion
        #region prop Notizen
        private notiz _selectedNotiz;

        public notiz SelectedNotiz
        {
            get { return _selectedNotiz; }
            set
            {
                if (_selectedNotiz != value)
                {
                    _selectedNotiz = value;
                    this.OnPropertyChanged();
                }
            }
        }
        private notiz _vertNotiz;

        public notiz VertNotiz
        {
            get { return _vertNotiz; }
            set
            {
                if (_vertNotiz != value)
                {
                    _vertNotiz = value;
                    this.OnPropertyChanged();
                }
            }
        }
        private IEnumerable<notiz> _vertNotizListe;

        public IEnumerable<notiz> VertNotizListe
        {
            get { return _vertNotizListe; }
            set
            {
                if (_vertNotizListe != value)
                {
                    _vertNotizListe = value;
                    this.OnPropertyChanged();
                }
            }
        }

        #endregion
        #region prop Doks

        private vwDokumente _selectedDok;

        public vwDokumente SelectedDok
        {
            get { return _selectedDok; }
            set
            {
                if (_selectedDok != value)
                {
                    _selectedDok = value;
                    this.OnPropertyChanged();
                }
            }
        }
        private vwDokumente _vertDok;

        public vwDokumente VertDok
        {
            get { return _vertDok; }
            set
            {
                if (_vertDok != value)
                {
                    _vertDok = value;
                    this.OnPropertyChanged();
                }
            }
        }
        private IEnumerable<vwDokumente> _vertDokListe;

        public IEnumerable<vwDokumente> VertDokListe
        {
            get { return _vertDokListe; }
            set
            {
                if (_vertDokListe != value)
                {
                    _vertDokListe = value;
                    this.OnPropertyChanged();
                }
            }
        }
        private dokument _vertDokNeu;

        public dokument VertDokNeu
        {
            get { return _vertDokNeu; }
            set
            {
                if (_vertDokNeu != value)
                {
                    _vertDokNeu = value;
                    this.OnPropertyChanged();
                }
            }
        }
        private IEnumerable<dokument> _vertDokListeNeu;

        public IEnumerable<dokument> VertDokListeNeu
        {
            get { return _vertDokListeNeu; }
            set
            {
                if (_vertDokListeNeu != value)
                {
                    _vertDokListeNeu = value;
                    this.OnPropertyChanged();
                }
            }
        }
        private List<string> _dokKatListe = new List<string>();

        public List<string> DokKatListe
        {
            get { return _dokKatListe; }
            set
            {
                if (_dokKatListe != value)
                {
                    _dokKatListe = value;
                    this.OnPropertyChanged();
                }
            }
        }
        #endregion
        #region prop Forderungen
        private vwVertragsforderung _selectedForderung;

        public vwVertragsforderung SelectedForderung
        {
            get { return _selectedForderung; }
            set
            {
                if (_selectedForderung != value)
                {
                    _selectedForderung = value;
                    this.OnPropertyChanged();
                }
            }
        }
        private bool _offeneForderungChecked;

        public bool OffeneForderungChecked
        {
            get { return _offeneForderungChecked; }
            set
            {
                if (_offeneForderungChecked != value)
                {
                    _offeneForderungChecked = value;
                    this.OnPropertyChanged();
                    //if value=true, VertFordListe = Abfrage where offen = true,
                    //if value = false VertFord = abfrage where offen = false;
                }
            }
        }

        private vwVertragsforderung _vertFord;

        public vwVertragsforderung VertFord
        {
            get { return _vertFord; }
            set
            {
                if (_vertFord != value)
                {
                    _vertFord = value;
                    this.OnPropertyChanged();
                }
            }
        }
        private IEnumerable<vwVertragsforderung> _vertFordListe;

        public IEnumerable<vwVertragsforderung> VertFordListe
        {
            get { return _vertFordListe; }
            set
            {
                if (_vertFordListe != value)
                {
                    _vertFordListe = value;
                    this.OnPropertyChanged();
                }
            }
        }

        #endregion
        #region prop Erstattungen
        private vwPersonenErstattungen _selectedErstattung;

        public vwPersonenErstattungen SelectedErstattung
        {
            get { return _selectedErstattung; }
            set
            {
                if (_selectedErstattung != value)
                {
                    _selectedErstattung = value;
                    this.OnPropertyChanged();
                }
            }
        }
        private bool _offeneErstattungChecked;

        public bool OffeneErstattungChecked
        {
            get { return _offeneErstattungChecked; }
            set
            {
                if (_offeneErstattungChecked != value)
                {
                    _offeneErstattungChecked = value;
                    this.OnPropertyChanged();
                    //if value=true, VertFordListe = Abfrage where offen = true,
                    //if value = false VertFord = abfrage where offen = false;
                }
            }
        }
        private vwPersonenErstattungen _erstattung;

        public vwPersonenErstattungen Erstattung
        {
            get { return _erstattung; }
            set
            {
                if (_erstattung != value)
                {
                    _erstattung = value;
                    this.OnPropertyChanged();
                }
            }
        }
        private IEnumerable<vwPersonenErstattungen> _erstattungenListe;

        public IEnumerable<vwPersonenErstattungen> ErstattungenListe
        {
            get { return _erstattungenListe; }
            set
            {
                if (_erstattungenListe != value)
                {
                    _erstattungenListe = value;
                    this.OnPropertyChanged();
                }
            }
        }

        #endregion
        //Konstruktor
        public VertragUpdateViewModel()
        {
            WerteAusÜbergabenAnProperties();
            Miete = GetMiete(ZuEinheit);
            MietPropertiesZuweisen(Miete);
            VertNotizListe = GetNotizen(VertID, MieterID);
            VertDokListe = GetDoks(VertID, Mieter);
            VertFordListe = GetForderungen(VertID);
            ErstattungenListe = GetErstattungen(MieterID);
            DokKatListe = GetDokKatListe();

            _saveAndChangeToVertragListeCommand = new RelayCommand(param => SaveAndChangeToVertragListe(param));
            _changeToVertragListeCommand = new RelayCommand(param => ChangeToVertragListeView(param));
        }

        #region Methoden
        private void MietPropertiesZuweisen(miete value)
        {
            if (value != null)
            {
                MietID = value.mietID;
                Kaltmiete = value.kaltmiete;
                GültigAb = value.gültigAb;
                NK = value.NkAbschlag;
                if (value.garage.HasValue)
                    Garage = (decimal)value.garage;
                if (value.stellplatz.HasValue)
                    Stellplatz = (decimal)value.stellplatz;
                if (value.sonstMietbestandteile.HasValue)
                    SonstMiete = (decimal)value.sonstMietbestandteile;
                BruttomieteBerechnen();
                var gkk = Stellplatz;
            }
        }

        private void BruttomieteBerechnen()
        {
            BruttoMiete = Kaltmiete + NK + Garage + Stellplatz + SonstMiete;
        }

        private void WerteAusÜbergabenAnProperties()
        {
            if (VertragslisteViewModel.übergabeObj != null)
                ObjektBez = VertragslisteViewModel.übergabeObj;

            if (VertragslisteViewModel.übergabeMieteinheit != null)
                MieteinheitBez = VertragslisteViewModel.übergabeMieteinheit;

            if (VertragslisteViewModel.übergabeMieter != null)
                Mieter = VertragslisteViewModel.übergabeMieter;

            if (VertragslisteViewModel.übergabeVermieter != null)
                Vermieter = VertragslisteViewModel.übergabeVermieter;

            selectedVertrag = GetVertrag(VertragslisteViewModel.übergabeID);
            if (selectedVertrag != null)
            {
                VertID = selectedVertrag.vertragsnr;
                ZuEinheit = selectedVertrag.zuEinheit;
                MieterID = selectedVertrag.mieter;
                Vertragsdatum = selectedVertrag.vertragsdatum;
                Vertragsbeginn = selectedVertrag.vertragsbeginn;
                Vertragsende = selectedVertrag.vertragsende;
                Kaution = Math.Round((decimal)selectedVertrag.kaution, 2);
                Kautionsraten = (int)selectedVertrag.kautionsraten;
                KautionBez = (bool)selectedVertrag.kautionBezahlt;
                Kündigungsfrist = selectedVertrag.kündigungsfrist;
                VertragAktiv = (bool)selectedVertrag.mietverhältnisAktiv;
                if (Kaution > 0 || Kautionsraten > 0)
                    KautionsratenHöhe = Math.Round(Kaution / Kautionsraten, 2);
            }
        }
        private List<string> GetDokKatListe()
        {
            using (immoEntities context = new immoEntities())
            {
                var query = context.dokumentenkategories.ToList().OrderBy(p => p.kategorie);
                if (query != null)
                {
                    foreach (var kat in query)
                    {
                        DokKatListe.Add(kat.kategorie);
                    }

                    
                }return DokKatListe;
            }

        }

        private miete GetMiete(int einheitid)
        {
            using (immoEntities context = new immoEntities())
            {
                var mie = context.wohneinheitMietes.Where(p => p.einheit == einheitid && p.aktiv == true).FirstOrDefault().miete;
                miete miet = mie;
                return miet;
            }
        }

        public static mietvertrag GetVertrag(int id)
        {
            using (immoEntities context = new immoEntities())
            {
                var query = context.mietvertrags.Where(p => p.vertragsnr == id).FirstOrDefault();
                mietvertrag miet = query;
                return miet;
            }
        }
        public static List<notiz> GetNotizen(int VertID, int MieterID)
        {
            using (immoEntities context = new immoEntities())
            {
                var liste = (from p in context.notizs select p).Where(p => p.zuVertrag == VertID && (p.zuPerson == MieterID || p.zuPerson == null)).OrderByDescending(p => p.datum);

                List<notiz> nots = new List<notiz>();
                foreach (var item in liste)
                {
                    notiz not = new notiz();
                    not.notizID = item.notizID;
                    not.datum = item.datum;
                    not.notizText = item.notizText;
                    nots.Add(not);
                }
                return nots;
            }
        }
        public static List<vwDokumente> GetDoks(int VertID, string Mieter)
        {
            using (immoEntities context = new immoEntities())
            {
                var liste = (from p in context.vwDokumentes select p).Where(p => p.zu_Vertagsnr == VertID && (p.zu_Person == Mieter || p.zu_Person == null)).OrderByDescending(p => p.datum);

                List<vwDokumente> doks = new List<vwDokumente>();
                foreach (var item in liste)
                {
                    vwDokumente dok = new vwDokumente();
                    dok.dokID = item.dokID;
                    dok.Art = item.Art;
                    dok.datum = item.datum;
                    dok.titel = item.titel;
                    doks.Add(dok);
                }
                return doks;
            }
        }

        public static List<vwVertragsforderung> GetForderungen(int VertID)
        {
            using (immoEntities context = new immoEntities())
            {
                var liste = (from p in context.vwVertragsforderungs select p).Where(p => p.Vertragsnr == VertID).OrderByDescending(p => p.Fällig_am);

                List<vwVertragsforderung> fords = new List<vwVertragsforderung>();
                foreach (var item in liste)
                {
                    vwVertragsforderung ford = new vwVertragsforderung();
                    ford.Forderungsnr = item.Forderungsnr;
                    ford.Fällig_am = item.Fällig_am;
                    ford.Betrag = item.Betrag;
                    ford.Beglichen_am = item.Beglichen_am;
                    ford.offen = item.offen;
                    fords.Add(ford);
                }
                return fords;
            }
        }
        public static IEnumerable<vwPersonenErstattungen> GetErstattungen(int MieterID)
        {
            using (immoEntities context = new immoEntities())
            {
                var liste = (from p in context.vwPersonenErstattungens select p).Where(p => p.KontaktID == MieterID).OrderByDescending(p => p.Fällig_am);

                List<vwPersonenErstattungen> ersts = new List<vwPersonenErstattungen>();
                foreach (var item in liste)
                {
                    vwPersonenErstattungen erst = new vwPersonenErstattungen();
                    erst.KontaktID = item.KontaktID;
                    erst.Vorname = item.Vorname;
                    erst.Name = item.Name;
                    erst.ErstattungsNr = item.ErstattungsNr;
                    erst.Erstattungsgrund = item.Erstattungsgrund;
                    erst.Fällig_am = item.Fällig_am;
                    erst.Betrag = item.Betrag;
                    erst.Erstattet_am = item.Erstattet_am;
                    erst.erledigt = item.erledigt;

                    ersts.Add(erst);
                }
                return ersts;
            }
        }
        private void PropertiesAufÄnderungenUndNullPrüfen()
        {

            //if Vertragsende geändert, bzw gefüllt, prüfen ob in Zukunft oder Vegangenheit, update ubnd status ggf anpassen
            //if KautionBez geändert = update in DB

            //if Miete PropsChanged => neuer DS, we/miete neuer DS=> aktiv = true, aktueller: aktiv = false;
            //    Miete
            //  MietID
            //   Kaltmiete
            //  GültigAb
            //   NK
            //  Garage
            //  Stellplatz
            //   SonstMiete
            // BruttoMiete


            //notNeu 
            //  VertNotizListe Neu  = wenn VertNotizListeNeu Liste.Length > 1, foreach item, Notiz speichern, Zu Vertrag = vertID


            //   VertDokNeu
            //   VertDokListeNeu = wenn VertNeu Liste.Length > 1, foreach item, Dok speichern, Zu Vertrag = vertID


        }

        #endregion
        #region Commands
        //ToDo: Commands implementieren und an die View binden

        private bool _canExecute = true;
        public bool CanExecute
        {
            get { return this._canExecute; }
            set
            {
                if (this._canExecute == value)
                    return;

                this._canExecute = value;
            }
        }
        private ICommand _saveAndChangeToVertragListeCommand;
        public ICommand SaveAndChangeToVertragListeCommand
        {
            get { return _saveAndChangeToVertragListeCommand; }
            set { _saveAndChangeToVertragListeCommand = value; }
        }

        private void SaveAndChangeToVertragListe(object o)
        {
            //Properties als Werte in DB-Abfrage einsetzen, DBUpdate => tbmietvertrag
            //Neue Doks in tb. Dokumente und Tb dokument
            //Neue Notizen in tb Notiz
            // Neue Forderung in tb Forderung
            //Neue Erstattung in TB Erstattung

            //neue Miete in tb miete, tb wohneinheit miete, alte Miete aktiv = false
            MessageBoxResult result = MessageBox.Show("Sind alle Eingabe korrekt?", "Speichern", MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.No);

            if (result == MessageBoxResult.No)
                return;
            else
                PropertiesAufÄnderungenUndNullPrüfen();
            //Speichern if erfolgreich:
            MessageBox.Show("Daten wurden in der Db gespeichert");
            VertragslisteViewModel.win.Close();
            // if Fehler:
            //Message: Fehler beim Speichern

        }


        private ICommand _changeToVertragListeCommand;
        public ICommand ChangeToVertragListeCommand
        {
            get { return _changeToVertragListeCommand; }
            set { _changeToVertragListeCommand = value; }
        }

        private void ChangeToVertragListeView(object o)
        {
            MessageBoxResult result = MessageBox.Show("Sind Sie sicher? Alle neuen Eingaben werden gelöscht", "Abbrechen", MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.No);

            if (result == MessageBoxResult.No)
                return;
            else
            {
                MessageBox.Show("geänderte Daten wurden gelöscht");
                VertragslisteViewModel.win.Close();
            }


        }

        #endregion


    }
}