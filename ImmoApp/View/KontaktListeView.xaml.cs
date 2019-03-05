using ImmoApp.ViewModel;
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
    /// Interaktionslogik für KontaktListeView.xaml
    /// </summary>
    public partial class KontaktListeView : UserControl
    {
        public KontaktListeView()
        {
            InitializeComponent();
            KontaktListeViewModel klvm = new KontaktListeViewModel();
            this.DataContext = klvm;
        }

        private void btnAuswahl_Click(object sender, RoutedEventArgs e)
        {
            Bearbeiten(new KontaktUpdateView(), "Kontakt bearbeiten");
        }

        private void btnNeu_Click(object sender, RoutedEventArgs e)
        {
            Neu(new KontaktInsertView(), "Neuer Kontakt");
        }
    }
}
