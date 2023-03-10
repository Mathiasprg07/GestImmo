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

namespace GestImmo.Views
{
    /// <summary>
    /// Logique d'interaction pour MaisonDetailView.xaml
    /// </summary>
    public partial class MaisonDetailView : Page
    {
        public MaisonDetailView(Maison maison)
        {
            InitializeComponent();
            TxtMaisonNom.Text = maison.Nom;
            TxtMaisonValeur.Text = maison.Valeur.ToString();
            TxtMaisonAdresse.Text = maison.Adresse;
            TxtMaisonSurface.Text = maison.Surface.ToString();
            TxtMaisonNbPieces.Text = maison.nbPieces.ToString();
            TxtMaisonNbChambres.Text = maison.nbChambres.ToString();
            TxtMaisonNbCaves.Text = maison.nbCaves.ToString();
            TxtMaisonNbParkings.Text = maison.nbParking.ToString();

        }

        private void TxtMaisonNom_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TxtMaisonValeur_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TxtMaisonAdresse_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TxtMaisonSurface_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TxtMaisonNbPieces_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TxtMaisonNbChambres_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TxtMaisonNbCaves_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TxtMaisonNbParkings_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
