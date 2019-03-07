using ImmoApp.ViewModel;
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
        MieteinheitListeView mlv = new MieteinheitListeView();
        VertragslisteView vlv = new VertragslisteView();
        KontaktListeView klv = new KontaktListeView();
        EinnahmenListeView elv = new EinnahmenListeView();
        ForderungListeView flv = new ForderungListeView();
        ErstattungsListeView erlv = new ErstattungsListeView();
        DokumentenListeView dlv = new DokumentenListeView();
        VorlageListeView volv = new VorlageListeView();
        EinstellungenView ev = new EinstellungenView();
        BankListeView blv = new BankListeView();
        KontenListeView ktolv = new KontenListeView();
        List<UserControl> PageList = new List<UserControl>();
        StartViewModel svm = new StartViewModel();

        public StartView()
        {
            InitializeComponent();
            PageList.Add(olv);
            PageList.Add(mlv);
            PageList.Add(vlv);
            PageList.Add(klv);
            PageList.Add(elv);
            PageList.Add(flv);
            PageList.Add(erlv);
            PageList.Add(dlv);
            PageList.Add(volv);
            PageList.Add(ev);
            PageList.Add(blv);
            PageList.Add(ktolv);

            this.DataContext = svm;
        }

        #region Click_Events => Commands

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

            svm.ChangeViewCommand.Execute(new ObjektInsertView());
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ObjektBearbButton_Click(object sender, RoutedEventArgs e)
        {
            svm.ChangeViewCommand.Execute(new ObjektUpdateView());
        }

        private void EinheitenButton_Click(object sender, RoutedEventArgs e)
        {
            navFrame.NavigationService.Content = mlv;
        }

        private void EinheitNeuButton_Click(object sender, RoutedEventArgs e)
        {
            svm.ChangeViewCommand.Execute(new MieteinheitInsertView());
        }

        private void EinheitBearbButton_Click(object sender, RoutedEventArgs e)
        {
            svm.ChangeViewCommand.Execute(new MieteinheitUpdateView());
        }

        private void VertragNeuButton_Click(object sender, RoutedEventArgs e)
        {
            svm.ChangeViewCommand.Execute(new VertragInsertView());
        }

        private void VerträgeButton_Click(object sender, RoutedEventArgs e)
        {
            navFrame.NavigationService.Content = vlv;
        }

        private void VertragBearbButton_Click(object sender, RoutedEventArgs e)
        {
            svm.ChangeViewCommand.Execute(new VertragUpdateView());
        }

        private void ToolsButton_Click(object sender, RoutedEventArgs e)
        {
            svm.ChangeViewCommand.Execute(new EinstellungenView());
        }

        private void KontakteButton_Click(object sender, RoutedEventArgs e)
        {
            navFrame.NavigationService.Content = klv;
        }

        private void KontaktNeuButton_Click(object sender, RoutedEventArgs e)
        {
            svm.ChangeViewCommand.Execute(new KontaktInsertView());
        }

        private void KontaktBearbButton_Click(object sender, RoutedEventArgs e)
        {
            svm.ChangeViewCommand.Execute(new KontaktUpdateView());
        }

        private void EinnahmenButton_Click(object sender, RoutedEventArgs e)
        {
            navFrame.NavigationService.Content = elv;
        }

        private void EinnahmeNeuButton_Click(object sender, RoutedEventArgs e)
        {
            svm.ChangeViewCommand.Execute(new EinnahmeInsertView());
        }

        private void EinnahmeBearbButton_Click(object sender, RoutedEventArgs e)
        {
            svm.ChangeViewCommand.Execute(new EinnahmeUpdateView());
        }

        private void ForderungenButton_Click(object sender, RoutedEventArgs e)
        {
            navFrame.NavigationService.Content = flv;
        }

        private void ForderungNeuButton_Click(object sender, RoutedEventArgs e)
        {
            svm.ChangeViewCommand.Execute(new ForderungInsertView());
        }

        private void ForderungBearbButon_Click(object sender, RoutedEventArgs e)
        {
            svm.ChangeViewCommand.Execute(new ForderungUpdateView());
        }

        private void ErstattungenButton_Click(object sender, RoutedEventArgs e)
        {
            navFrame.NavigationService.Content = erlv;
        }

        private void ErstattungNeuButton_Click(object sender, RoutedEventArgs e)
        {
            svm.ChangeViewCommand.Execute(new ErstattungInsertView());
        }

        private void ErstattungBearbButton_Click(object sender, RoutedEventArgs e)
        {
            svm.ChangeViewCommand.Execute(new ErstattungUpdateView());
        }

        private void DokumenteButton_Click(object sender, RoutedEventArgs e)
        {
            navFrame.NavigationService.Content = dlv;
        }

        private void DokNeuButton_Click(object sender, RoutedEventArgs e)
        {
            svm.ChangeViewCommand.Execute(new DokumentInsertView());
        }

        private void DokBearbButton_Click(object sender, RoutedEventArgs e)
        {
            svm.ChangeViewCommand.Execute(new DokumentUpdateView());
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
        #endregion
    }
}
