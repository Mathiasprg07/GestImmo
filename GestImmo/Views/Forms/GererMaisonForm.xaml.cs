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
using ConsoleApp.PostgreSQL;
using GestImmo.DATA.Models;

namespace GestImmo.Views.Forms
{
    /// <summary>
    /// Logique d'interaction pour GererMaison.xaml
    /// </summary>
    public partial class GererMaison : Page
    {
        GestImmoContext ctx = GestImmoContext.getInstance();
        public GererMaison()
        {
            InitializeComponent();
        }
        private void TxtMaisonNom_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextMaisonValeur_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextMaisonAdresse_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextMaisonSurface_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextMaisonNbPieces_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextMaisonNbChambres_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextMaisonNbCaves_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextMaisonNbParkings_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void BtnAjouter_Click(object sender, RoutedEventArgs e)
        {
            Bien maison = new Maison(TxtMaisonNom.Text, int.Parse(TxtMaisonValeur.Text), TxtMaisonAdresse.Text, int.Parse(TxtMaisonSurface.Text), int.Parse(TxtMaisonNbPieces.Text), int.Parse(TxtMaisonNbChambres.Text), int.Parse(TxtMaisonNbCaves.Text), int.Parse(TxtMaisonNbParkings.Text));
            ctx.Biens.Add(maison);
            ctx.SaveChanges();
        }
    }
}
