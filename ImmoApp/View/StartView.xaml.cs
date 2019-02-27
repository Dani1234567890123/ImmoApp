using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
        MieteinheitInsertView miv = new MieteinheitInsertView();
        VertragslisteView vlv = new VertragslisteView();
        VertragUpdateView vuv = new VertragUpdateView();
        VertragInsertView viv = new VertragInsertView();
        KontaktListeView klv = new KontaktListeView();
        KontaktUpdateView kuv = new KontaktUpdateView();
        KontaktInsertView kiv = new KontaktInsertView();
        EinnahmenListeView elv = new EinnahmenListeView();
        EinnahmeUpdateView euv = new EinnahmeUpdateView();
        EinnahmeInsertView eiv = new EinnahmeInsertView();
        ForderungListeView flv = new ForderungListeView();
        ForderungUpdateView fuv = new ForderungUpdateView();
        ForderungInsertView fiv = new ForderungInsertView();
        ErstattungsListeView erlv = new ErstattungsListeView();
        ErstattungUpdateView eruv = new ErstattungUpdateView();
        ErstattungInsertView eriv = new ErstattungInsertView();
        DokumentenListeView dlv = new DokumentenListeView();
        DokumentUpdateView duv = new DokumentUpdateView();
        DokumentInsertView div = new DokumentInsertView();
        VorlageListeView volv = new VorlageListeView();
        EinstellungenView ev = new EinstellungenView();

        List<Page> PageList = new List<Page>();

        public StartView()
        {
            InitializeComponent();
            navFrame.NavigationService.Content = oiv;

            
            PageList.Add(olv);
            PageList.Add(ouv);
            PageList.Add(mlv);
            PageList.Add(muv);
            PageList.Add(miv);
            PageList.Add(vlv);
            PageList.Add(vuv);
            PageList.Add(viv);
            PageList.Add(klv);
            PageList.Add(kuv);
            PageList.Add(kiv);
            PageList.Add(elv);
            PageList.Add(euv);
            PageList.Add(eiv);
            PageList.Add(flv);
            PageList.Add(fuv);
            PageList.Add(fiv);
            PageList.Add(erlv);
            PageList.Add(eruv);
            PageList.Add(eriv);
            PageList.Add(dlv);
            PageList.Add(duv);
            PageList.Add(div);
            PageList.Add(volv);
            PageList.Add(ev);
            
            
        }

    }
}
