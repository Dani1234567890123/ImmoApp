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
    /// Interaktionslogik für ForderungListeView.xaml
    /// </summary>
    public partial class ForderungListeView : UserControl
    {
        public ForderungListeView()
        {
            InitializeComponent();
            ForderungListeViewModel flvm = new ForderungListeViewModel();
            this.DataContext = flvm;
        }

        private void btnAuswahl_Click(object sender, RoutedEventArgs e)
        {
            Bearbeiten(new ForderungUpdateView(), "Forderung bearbeiten");
        }

        private void btnNeu_Click(object sender, RoutedEventArgs e)
        {
            Neu(new ForderungInsertView(), "Neue Forderung");
        }
    }
}
