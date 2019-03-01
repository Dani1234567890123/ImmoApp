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
    /// Interaktionslogik für ObjektInsertView.xaml
    /// </summary>
    public partial class ObjektInsertView : UserControl
    {
        public ObjektInsertView()
        {
            InitializeComponent();
        }

        private void ObjSpeichernButton_Click(object sender, RoutedEventArgs e)
        {
            //Abfrage, ob alle Daten ok
            //Daten in DB speichern

            Speichern((Window)this.Parent);
           

        }

        private void Abbrechen_Click(object sender, RoutedEventArgs e)
        {
            Abbrechen((Window)this.Parent);

        }

        private void ObjInListeButton_Click(object sender, RoutedEventArgs e)
        {
            Zwischenspeichern("Objekt");
        }

        private void btnMENeu_Click(object sender, RoutedEventArgs e)
        {
            Neu(new MieteinheitInsertView(), "neue Mieteinheit");
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
    }
}
