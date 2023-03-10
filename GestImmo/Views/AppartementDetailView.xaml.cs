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
    /// Logique d'interaction pour AppartementDetailView.xaml
    /// </summary>
    public partial class AppartementDetailView : Page
    {
        public AppartementDetailView(Appartement appartement)
        {
            InitializeComponent();
            TxtAppartementEtages.Text = appartement.Etage.ToString();
            TxtAppartementNom.Text = appartement.Nom;
            TxtAppartementValeur.Text = appartement.Valeur.ToString();
            TxtAppartementAdresse.Text = appartement.Adresse;
            TxtAppartementSurface.Text = appartement.Surface.ToString();
            TxtAppartementNbPieces.Text = appartement.nbPieces.ToString();
            TxtAppartementNbChambres.Text = appartement.nbChambres.ToString();
            TxtAppartementNbCaves.Text = appartement.nbCaves.ToString();
            TxtAppartementNbParkings.Text = appartement.nbParking.ToString();
            TxtAppartementChauffCommun.Text = appartement.ChauffCommun.ToString();
            TxtAppartementAscenceurCommun.Text = appartement.Assenceur.ToString();

            if(appartement.ChauffCommun == true)
            {
                TxtAppartementChauffCommun.Text = "oui";
            }
            else
            {
                TxtAppartementChauffCommun.Text = "non";
            }

            if (appartement.Assenceur == true)
            {
                TxtAppartementAscenceurCommun.Text = "oui";
            }
            else
            {
                TxtAppartementAscenceurCommun.Text = "non";
            }

           
        }

        

        private void TxtAppartementEtages_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void TxtAppartementNom_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TxtAppartementValeur_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TxtAppartementAdresse_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TxtAppartementSurface_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TxtAppartementNbPieces_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TxtAppartementNbChambres_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TxtAppartementNbCaves_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TxtAppartementNbParkings_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TxtAppartementChauffCommun_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TxtAppartementAscenceurCommun_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
