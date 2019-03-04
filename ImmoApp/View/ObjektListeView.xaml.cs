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
    /// Interaktionslogik für ObjektListeView.xaml
    /// </summary>
    public partial class ObjektListeView : UserControl
    {
        public ObjektListeView()
        {
            InitializeComponent();
            ObjektListeViewModel olvm = new ObjektListeViewModel();
            this.DataContext = olvm;
        }

        private void ObjBearbButton_Click(object sender, RoutedEventArgs e)
        {
            Bearbeiten(new ObjektUpdateView(), "Objekt bearbeiten");
        }

        private void ObjNeuButton_Click(object sender, RoutedEventArgs e)
        {
            Neu(new ObjektInsertView(), "Neues Objekt");
        }

        private void cmbSort_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
