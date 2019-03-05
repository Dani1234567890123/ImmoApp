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
    /// Interaktionslogik für VorlageListeView.xaml
    /// </summary>
    public partial class VorlageListeView : UserControl
    {
        public VorlageListeView()
        {
            InitializeComponent();
            VorlageListeViewModel vlvm = new VorlageListeViewModel();
            this.DataContext = vlvm;
        }

        private void btnÖffnen_Click(object sender, RoutedEventArgs e)
        {
            DokÖffnen();
        }
    }
}
