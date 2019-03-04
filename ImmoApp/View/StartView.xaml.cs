using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using static ImmoApp.View.ButtonMethoden;

namespace ImmoApp.View
{
    /// <summary>
    /// Interaktionslogik für StartView.xaml
    /// </summary>
    public partial class StartView : RibbonWindow
    {

        StartPage sp = new StartPage();
        ObjektListeView olv = new ObjektListeView();
        ObjektUpdateView ouv = new ObjektUpdateView();
        ObjektInsertView oiv = new ObjektInsertView();
        MieteinheitListeView mlv = new MieteinheitListeView();
        MieteinheitUpdateView muv = new MieteinheitUpdateView();
        MieteinheitInsertView miv = new MieteinheitInsertView();
        VertragslisteView vlv = new VertragslisteView();
        VertragUpdateView vuv = new VertragUpdateView();
        VertragInsertView viv = new VertragInsertView();
        KontaktListeView klv = new KontaktListeView();
        KontaktUpdateView kuv = new KontaktUpdateView();
        KontaktInsertView kiv = new KontaktInsertView();
        EinnahmenListeView elv = new EinnahmenListeView();
        EinnahmeUpdateView euv = new EinnahmeUpdateView();
        EinnahmeInsertView eiv = new EinnahmeInsertView();
        ForderungListeView flv = new ForderungListeView();
        ForderungUpdateView fuv = new ForderungUpdateView();
        ForderungInsertView fiv = new ForderungInsertView();
        ErstattungsListeView erlv = new ErstattungsListeView();
        ErstattungUpdateView eruv = new ErstattungUpdateView();
        ErstattungInsertView eriv = new ErstattungInsertView();
        DokumentenListeView dlv = new DokumentenListeView();
        public DokumentUpdateView duv = new DokumentUpdateView();
        DokumentInsertView div = new DokumentInsertView();
        VorlageListeView volv = new VorlageListeView();
        EinstellungenView ev = new EinstellungenView();
        BankListeView blv = new BankListeView();
        BankInsertView biv = new BankInsertView();
        BankUpdateView buv = new BankUpdateView();
        KontenListeView ktolv = new KontenListeView();
        KontoInsertView ktoiv = new KontoInsertView();
        KontoUpdateView ktouv = new KontoUpdateView();
        LeerstandView lv = new LeerstandView();

        List<UserControl> PageList = new List<UserControl>();

        public StartView()
        {
            InitializeComponent();
            //navFrame.NavigationService.Content = sp;


            PageList.Add(olv);
            PageList.Add(ouv);
            PageList.Add(mlv);
            PageList.Add(muv);
            PageList.Add(miv);
            PageList.Add(vlv);
            PageList.Add(vuv);
            PageList.Add(viv);
            PageList.Add(klv);
            PageList.Add(kuv);
            PageList.Add(kiv);
            PageList.Add(elv);
            PageList.Add(euv);
            PageList.Add(eiv);
            PageList.Add(flv);
            PageList.Add(fuv);
            PageList.Add(fiv);
            PageList.Add(erlv);
            PageList.Add(eruv);
            PageList.Add(eriv);
            PageList.Add(dlv);
            PageList.Add(duv);
            PageList.Add(div);
            PageList.Add(volv);
            PageList.Add(ev);
            PageList.Add(blv);
            PageList.Add(biv);
            PageList.Add(buv);
            PageList.Add(ktolv);
            PageList.Add(ktolv);
            PageList.Add(ktolv);
            PageList.Add(lv);
        }


        private void ObjekteRibbonButton_Click(object sender, RoutedEventArgs e)
        {
            navFrame.NavigationService.Content = olv;
        }

        private void StartRibbonButton_Click(object sender, RoutedEventArgs e)
        {
            navFrame.NavigationService.Content = sp;
        }

        private void ObjektNeuRibbonButton_Click(object sender, RoutedEventArgs e)
        {
            Neu(new ObjektInsertView(), "Neues Objekt");
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ObjektBearbButton_Click(object sender, RoutedEventArgs e)
        {
            Neu(new ObjektUpdateView(), "Objekt Bearbeiten");
        }

        private void EinheitenButton_Click(object sender, RoutedEventArgs e)
        {
            navFrame.NavigationService.Content = mlv;
        }

        private void EinheitNeuButton_Click(object sender, RoutedEventArgs e)
        {
            Neu(new MieteinheitInsertView(), "Neue Mieteinheit");
        }

        private void EinheitBearbButton_Click(object sender, RoutedEventArgs e)
        {
            Neu(new MieteinheitUpdateView(), "Mieteinheit Bearbeiten");
        }

        private void VertragNeuButton_Click(object sender, RoutedEventArgs e)
        {
            Neu(new VertragInsertView(), "neuer Vertrag");
        }

        private void VerträgeButton_Click(object sender, RoutedEventArgs e)
        {
            navFrame.NavigationService.Content = vlv;
        }

        private void VertragBearbButton_Click(object sender, RoutedEventArgs e)
        {
            Neu(new VertragUpdateView(), "Vertrag Bearbeiten");
        }

        private void ToolsButton_Click(object sender, RoutedEventArgs e)
        {
            Neu(new EinstellungenView(), "Kategorien zufügen");
        }

        private void KontakteButton_Click(object sender, RoutedEventArgs e)
        {
            navFrame.NavigationService.Content = klv;
        }

        private void KontaktNeuButton_Click(object sender, RoutedEventArgs e)
        {
            Neu(new KontaktInsertView(), "Neuer Kontakt");
        }

        private void KontaktBearbButton_Click(object sender, RoutedEventArgs e)
        {
            Neu(new KontaktUpdateView(), "Kontakt Bearbeiten");
        }

        private void EinnahmenButton_Click(object sender, RoutedEventArgs e)
        {
            navFrame.NavigationService.Content = elv;
        }

        private void EinnahmeNeuButton_Click(object sender, RoutedEventArgs e)
        {
            Neu(new EinnahmeInsertView(), "neue Einnahme buchen");
        }

        private void EinnahmeBearbButton_Click(object sender, RoutedEventArgs e)
        {
            Neu(new EinnahmeUpdateView(), "Einnahme bearbeiten");
        }

        private void ForderungenButton_Click(object sender, RoutedEventArgs e)
        {
            navFrame.NavigationService.Content = flv;
        }

        private void ForderungNeuButton_Click(object sender, RoutedEventArgs e)
        {
            Neu(new ForderungInsertView(), "Neue Forderung");
        }

        private void ForderungBearbButon_Click(object sender, RoutedEventArgs e)
        {
            Neu(new ForderungUpdateView(), "Forderung bearbeiten");
        }

        private void ErstattungenButton_Click(object sender, RoutedEventArgs e)
        {
            navFrame.NavigationService.Content = erlv;
        }

        private void ErstattungNeuButton_Click(object sender, RoutedEventArgs e)
        {
            Neu(new ErstattungInsertView(), "Neue Erstattung");
        }

        private void ErstattungBearbButton_Click(object sender, RoutedEventArgs e)
        {
            Neu(new ErstattungUpdateView(), "Erstatung bearbeiten");
        }

        private void DokumenteButton_Click(object sender, RoutedEventArgs e)
        {
            navFrame.NavigationService.Content = dlv;
        }

        private void DokNeuButton_Click(object sender, RoutedEventArgs e)
        {
            Neu(new DokumentInsertView(), "Neues Dokument speichern");
        }

        private void DokBearbButton_Click(object sender, RoutedEventArgs e)
        {
            Neu(new DokumentUpdateView(), "Dokument bearbeiten");
        }

        private void VorlagenButton_Click(object sender, RoutedEventArgs e)
        {
            navFrame.NavigationService.Content = volv;
        }

        private void BankenButton_Click(object sender, RoutedEventArgs e)
        {
            navFrame.NavigationService.Content = blv;
        }

        private void KontenButton_Click(object sender, RoutedEventArgs e)
        {
            navFrame.NavigationService.Content = ktolv;
        }
    }
}
