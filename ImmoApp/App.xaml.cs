using ImmoApp.View;
using ImmoApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace ImmoApp
{
    /// <summary>
    /// Interaktionslogik für "App.xaml"
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            StartView app = new StartView();
            StartViewModel context = new StartViewModel();
            app.DataContext = context;
            app.Show();
        }
    }
}
