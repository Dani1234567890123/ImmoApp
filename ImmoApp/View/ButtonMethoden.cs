using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace ImmoApp.View
{
    public static class ButtonMethoden
    {
        public static void Abbrechen(Window window)
        {
            Window win = new Window();
            win = window;
            MessageBoxResult result = MessageBox.Show("Sind Sie sicher? Alle Eingaben werden gelöscht", "Abbrechen", MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.No);
            if (result == MessageBoxResult.No)
                return;
            else
                win.Close();
        }

        public static void Speichern(Window window)
        {
            Window win = new Window();
            win = window;
            MessageBoxResult result = MessageBox.Show("Sind alle Eingabe korrekt?", "Speichern", MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.No);
            if (result == MessageBoxResult.No)
                return;
            else
                win.Close();
        }

        public static void Zwischenspeichern(string propName)
        {
            MessageBox.Show($"{propName} wird in der Liste zwischengespeichert");
        }
        public static void Neu(UserControl uc, string titel)
        {
            Window winNeu = new Window();
            winNeu.Content = uc;
            winNeu.Title = titel;
            winNeu.Show();
        }
        public static void Bearbeiten(UserControl uc, string titel)
        {
            Window winNeu = new Window();
            winNeu.Content = uc;
            winNeu.Title = titel;
            winNeu.Show();
        }

        public static void DokÖffnen()
        {
            MessageBox.Show("Datei wird extern geöffnet");
        }


    }
}
