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
    /// Interaktionslogik für EinnahmenListeView.xaml
    /// </summary>
    public partial class EinnahmenListeView : UserControl
    {
        public EinnahmenListeView()
        {
            InitializeComponent();
        }

        private void btnAuswahl_Click(object sender, RoutedEventArgs e)
        {
            Bearbeiten(new EinnahmeUpdateView(), "Einnahme bearbeiten");
        }

        private void btnNeu_Click(object sender, RoutedEventArgs e)
        {
            Neu(new EinnahmeInsertView(), "neue Einnahme buchen");
        }
    }
}
