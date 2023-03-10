using ConsoleApp.PostgreSQL;
using GestImmo.DATA.Models;
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
using GestImmo.Views.SubView;
using GestImmo.Views.Forms;

namespace GestImmo.Views
{
    /// <summary>
    /// Logique d'interaction pour BienView.xaml
    /// </summary>
    public partial class BienView : Page
    {
        GestImmoContext gestImmocontext = GestImmoContext.getInstance();
        ListBienView bienView;
        
        public BienView()
        {
            InitializeComponent();
            bienView = new ListBienView(FrameBienAjouter);
            this.FrameBienListe.Navigate(bienView);
            this.FrameBienAjouter.Navigate(new GererBienForm(this.bienView));


        }

        private void ListeBien1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ListeBiens_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

    }
}

