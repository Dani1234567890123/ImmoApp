using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static ImmoApp.View.ButtonMethoden;

namespace ImmoApp.View
{
    /// <summary>
    /// Interaktionslogik für KontaktUpdateView.xaml
    /// </summary>
    public partial class KontaktUpdateView : UserControl
    {
        public KontaktUpdateView()
        {
            InitializeComponent();
        }

        private void btnKatNeu_Click(object sender, RoutedEventArgs e)
        {
            Neu(new EinstellungenView(), "Kategorien zufügen");
        }

        private void btnAnredeNeu_Click(object sender, RoutedEventArgs e)
        {
            Neu(new EinstellungenView(), "Kategorien zufügen");
        }

        private void btnNummerNeu_Click(object sender, RoutedEventArgs e)
        {
            Zwischenspeichern("Nummer / Email");
        }

        private void btnKtoBearb_Click(object sender, RoutedEventArgs e)
        {
            Neu(new KontoUpdateView(), "Kategorien zufügen");
        }

        private void btnKtoNeu_Click(object sender, RoutedEventArgs e)
        {
            Neu(new KontoInsertView(), "Neues Konto");
        }

        private void btnNotiz_Click(object sender, RoutedEventArgs e)
        {
            Zwischenspeichern("Notiz");
        }

        private void btnDokAnzeigen_Click(object sender, RoutedEventArgs e)
        {
            DokÖffnen();
        }

        private void btnOfD_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == true)
            {
                lblFile.Content = ofd.FileName;
            }
        }

        private void btnDokSave_Click(object sender, RoutedEventArgs e)
        {
            Zwischenspeichern("Dokument");
        }

        private void btnFordAnzeigen_Click(object sender, RoutedEventArgs e)
        {
            Bearbeiten(new ForderungUpdateView(), "Forderung bearbeiten");
        }

        private void btnFordNeu_Click(object sender, RoutedEventArgs e)
        {
            Neu(new ForderungInsertView(), "Neue Forderung");
        }

        private void btnErstAnzeigen_Click(object sender, RoutedEventArgs e)
        {
            Bearbeiten(new ErstattungUpdateView(), "Erstattung bearbeiten");
        }

        private void btnErstNeu_Click(object sender, RoutedEventArgs e)
        {
            Neu(new ErstattungInsertView(), "Neue Erstattung");
        }

        private void btnspeichern_Click(object sender, RoutedEventArgs e)
        {
            Speichern((Window)this.Parent);
        }

        private void btnAbbruch_Click(object sender, RoutedEventArgs e)
        {
            Abbrechen((Window)this.Parent);
        }
    }
}
