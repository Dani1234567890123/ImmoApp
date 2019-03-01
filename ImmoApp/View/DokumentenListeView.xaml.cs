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

namespace ImmoApp.View
{
    /// <summary>
    /// Interaktionslogik für DokumentenListeView.xaml
    /// </summary>
    public partial class DokumentenListeView : UserControl
    {
        
        DokumentInsertView div = new DokumentInsertView();
        StartViewModel sv = new StartViewModel();
        public DokumentenListeView()
        {
            InitializeComponent();
        }

        private void DokBearbButton_Click(object sender, RoutedEventArgs e)
        {
            sv.ChangeViewModel(new DokumentUpdateView() as IPageViewModel);
        }

        //private void DokNeuButton_Click(object sender, RoutedEventArgs e)
        //{
        //    sv.navFrame.NavigationService.Content = div;
        //}
    }
}
