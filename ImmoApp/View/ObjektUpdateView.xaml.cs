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
    /// Interaktionslogik für ObjektUpdateView.xaml
    /// </summary>
    public partial class ObjektUpdateView : UserControl
    {
        public ObjektUpdateView()
        {
            InitializeComponent();
            
        }



        private void btnNotiz_Click(object sender, RoutedEventArgs e)
        {
            Zwischenspeichern("Notiz");
        }

        private void btnMEanzeigen_Click(object sender, RoutedEventArgs e)
        {
            Bearbeiten(new MieteinheitUpdateView(), "Mieteinheit bearbeiten");
        }

        private void btnMENeu_Click(object sender, RoutedEventArgs e)
        {
            Neu(new MieteinheitInsertView(), "Neue Mieteinheit");
        }

        private void btnDokAnzeigen_Click(object sender, RoutedEventArgs e)
        {
            //SelectedItem des DataGrid
            DokÖffnen();


        }

        private void btnOfD_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == true)
            {
                lblFile.Content = ofd.FileName;
            }
        }

        private void btnDokSave_Click(object sender, RoutedEventArgs e)
        {
            Zwischenspeichern("Dokument");
        }
        private void btnspeichern_Click(object sender, RoutedEventArgs e)
        {
            ButtonMethoden.Speichern((Window)this.Parent);

        }
        private void btnAbbruch_Click(object sender, RoutedEventArgs e)
        {
            ButtonMethoden.Abbrechen((Window)this.Parent);
        }
    }
}
