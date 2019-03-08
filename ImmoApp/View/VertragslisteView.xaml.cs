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
    /// Interaktionslogik für VertragslisteView.xaml
    /// </summary>
    public partial class VertragslisteView : UserControl
    {
        VertragslisteViewModel vlvm = new VertragslisteViewModel();
        public VertragslisteView()
        {
            InitializeComponent();
            
            this.DataContext = vlvm;
        }

        private void btnAuswahl_Click(object sender, RoutedEventArgs e)
        {
            vlvm.ChangeToVertragUpdateCommand.Execute(new VertragUpdateView());
           
        }

        private void btnNeu_Click(object sender, RoutedEventArgs e)
        {
           vlvm.ChangeToVertragInsertCommand.Execute(new VertragInsertView());
        }

        private void dgVerträge_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            vlvm.SelectedVertrag = (vwVerträge)dgVerträge.SelectedItem;
        }
    }
}
