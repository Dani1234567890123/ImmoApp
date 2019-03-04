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
    /// Interaktionslogik für KontaktInsertView.xaml
    /// </summary>
    public partial class KontaktInsertView : UserControl
    {
        public KontaktInsertView()
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

        private void btnBankNeu_Click(object sender, RoutedEventArgs e)
        {
            Neu(new BankInsertView(), "Bank zufügen");
        }

        private void btnNotiz_Click(object sender, RoutedEventArgs e)
        {
            Zwischenspeichern("Notiz");
        }

        private void btnOfD_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == true)
            {
                lblFile.Content = ofd.FileName;
            }
        }

        private void btnFordNeu_Click(object sender, RoutedEventArgs e)
        {
            Neu(new ForderungInsertView(), "Neue Forderung");
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

        private void btnWeitKontakt_Click(object sender, RoutedEventArgs e)
        {
            Zwischenspeichern("Kontakt");
        }

        private void btnWeitKto_Click(object sender, RoutedEventArgs e)
        {
            Zwischenspeichern("Bankverbindung");
        }
    }
}
