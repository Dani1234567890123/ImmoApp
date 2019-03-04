﻿using System;
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
    /// Interaktionslogik für EinstellungenView.xaml
    /// </summary>
    public partial class EinstellungenView : UserControl
    {
        
        List<string> Kontaktkat = new List<string>();
        List<string> Zahlungskat = new List<string>();
        List<string> AnredeKat = new List<string>();
        List<string> Dokumentkat = new List<string>();

        public EinstellungenView()
        {
            InitializeComponent();
        }

        private void btnAddKat_Click(object sender, RoutedEventArgs e)
        {
            Kontaktkat.Add(tbKat.Text);
            lbKontKat.Items.Add(tbKat.Text);
        }

        private void btnAddZahlKat_Click(object sender, RoutedEventArgs e)
        {
            Zahlungskat.Add(tbZahlKat.Text);
            lbZahlKat.Items.Add(tbZahlKat.Text);
        }

        private void btnAddAnrde_Click(object sender, RoutedEventArgs e)
        {
            AnredeKat.Add(tbAnrede.Text);
            lbAnrede.Items.Add(tbAnrede.Text);
        }

        private void btnAddDokKat_Click(object sender, RoutedEventArgs e)
        {
            Dokumentkat.Add(tbDokKat.Text);
            lbDoklKat.Items.Add(tbDokKat.Text);
        }

        private void btnspeichern_Click(object sender, RoutedEventArgs e)
        {
            foreach (var item in Kontaktkat)
            {
                //Speichern in DB
            }
            foreach (var item in Zahlungskat)
            {
                //Speichern in DB
            }
            foreach (var item in AnredeKat)
            {
                //Speichern in DB
            }
            foreach (var item in Dokumentkat)
            {
                //Speichern in DB
            }
            Speichern((Window)this.Parent);
        }

        private void btnAbbruch_Click(object sender, RoutedEventArgs e)
        {
            Abbrechen((Window)this.Parent);
        }
    }
}
