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
    /// Interaktionslogik für ForderungUpdateView.xaml
    /// </summary>
    public partial class ForderungUpdateView : UserControl
    {
        public ForderungUpdateView()
        {
            InitializeComponent();
        }

        private void btnKatNeu_Click(object sender, RoutedEventArgs e)
        {
            Neu(new EinstellungenView(), "Kategorie zufügen");
        }

        private void btnEinnNeu_Click(object sender, RoutedEventArgs e)
        {
            Neu(new EinnahmeInsertView(), "neue Einnahme buchen");
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
