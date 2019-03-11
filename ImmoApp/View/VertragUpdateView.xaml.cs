using ImmoApp.ViewModel;
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
    /// Interaktionslogik für VertragUpdateView.xaml
    /// </summary>
    public partial class VertragUpdateView : UserControl
    {
        public VertragUpdateViewModel vuvm = new VertragUpdateViewModel();
        public VertragUpdateView()
        {
            InitializeComponent();
            this.DataContext = vuvm;
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

        private void btnDokNeu_Click(object sender, RoutedEventArgs e)
        {
            Zwischenspeichern("Dokument");
        }

        private void btnFordAnzeigen_Click(object sender, RoutedEventArgs e)
        {
            Bearbeiten(new ForderungUpdateView(), "Forderung bearbeiten");
        }

        private void btnFordNeu_Click(object sender, RoutedEventArgs e)
        {
            Neu(new ForderungInsertView(), "Neue Forderung");
        }

        private void btnErstAnzeigen_Click(object sender, RoutedEventArgs e)
        {
            Bearbeiten(new ErstattungUpdateView(), "Erstattung Bearbeiten");
        }

        private void btnErstNeu_Click(object sender, RoutedEventArgs e)
        {
            Neu(new ErstattungInsertView(), "Neue Erstattung");
        }

        private void btnspeichern_Click(object sender, RoutedEventArgs e)
        {
            vuvm.SaveAndChangeToVertragListeCommand.Execute(new Object());
            //Speichern((Window)this.Parent);
        }

        private void btnAbbruch_Click(object sender, RoutedEventArgs e)
        {
            vuvm.ChangeToVertragListeCommand.Execute(new Object());
            //Abbrechen((Window)this.Parent);
        }

        private void dgNotizen_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            vuvm.SelectedNotiz = (notiz)dgNotizen.SelectedItem;
        }

        private void dgdokument_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            vuvm.SelectedDok = (vwDokumente)dgdokument.SelectedItem;
        }

        private void dgForderungen_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            vuvm.SelectedForderung = (vwVertragsforderung)dgForderungen.SelectedItem;
        }

        private void chkFord_Checked(object sender, RoutedEventArgs e)
        {
            vuvm.OffeneForderungChecked = true;
        }

        private void chkErst_Checked(object sender, RoutedEventArgs e)
        {
            vuvm.OffeneErstattungChecked = true;
        }

        private void dgErstattungen_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            vuvm.OffeneErstattungChecked = true;
        }
    }
}
