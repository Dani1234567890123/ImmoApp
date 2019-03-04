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
    /// Interaktionslogik für KontoUpdateView.xaml
    /// </summary>
    public partial class KontoUpdateView : UserControl
    {
        public KontoUpdateView()
        {
            InitializeComponent();
        }

        private void btnBankNeu_Click(object sender, RoutedEventArgs e)
        {
            Neu(new BankInsertView(), "Neues Kreditinstitut");
        }

        private void btnKontNeu_Click(object sender, RoutedEventArgs e)
        {
            Neu(new KontoInsertView(), "Neue Bankverbindung");
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
