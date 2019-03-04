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
    /// Interaktionslogik für MieteinheitUpdateView.xaml
    /// </summary>
    public partial class MieteinheitUpdateView : UserControl
    {
        public MieteinheitUpdateView()
        {
            InitializeComponent();
        }

        private void btnNotiz_Click(object sender, RoutedEventArgs e)
        {
            Zwischenspeichern("Notiz");
        }

        private void btnDokAnzeigen_Click(object sender, RoutedEventArgs e)
        {
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

        private void btnVertragAnzeigen_Click(object sender, RoutedEventArgs e)
        {
            Bearbeiten(new VertragUpdateView(), "Vertrag bearbeiten"); 
        }

        private void btnVertragNeu_Click(object sender, RoutedEventArgs e)
        {
            Neu(new VertragInsertView(), "Neuer Vertrag");
        }

        private void btnLeerstandNeu_Click(object sender, RoutedEventArgs e)
        {
            Neu(new LeerstandView(), "Leerstände");
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
