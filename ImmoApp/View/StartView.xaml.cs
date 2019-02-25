﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ImmoApp.View
{
    /// <summary>
    /// Interaktionslogik für StartView.xaml
    /// </summary>
    public partial class StartView : RibbonWindow
    {
       
        StartPage sp = new StartPage();
        ObjektListeView olv = new ObjektListeView();
        ObjektUpdateView ouv = new ObjektUpdateView();
        ObjektInsertView oiv = new ObjektInsertView();
        MieteinheitListeView mlv = new MieteinheitListeView();
        MieteinheitUpdateView muv = new MieteinheitUpdateView();
        public StartView()
        {
            InitializeComponent();
            navFrame.NavigationService.Content = muv;
        }
    }
}