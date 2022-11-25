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
    /// Logique d'interaction pour GererAppartement.xaml
    /// </summary>
    public partial class GererAppartement : Page
    {
        GestImmoContext cxt = GestImmoContext.getInstance();
        public GererAppartement()
        {
            InitializeComponent();
        }
        private void TxtAppartementNom_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextAppartementValeur_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextAppartementAdresse_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextAppartementSurface_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextAppartementNbPieces_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextAppartementNbChambres_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextAppartementNbCaves_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextAppartementNbParkings_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextAppartementEtages_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextAppartementAscenseur_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextAppartementChauffCommun_TextChanged(object sender, TextChangedEventArgs e)
        {

        }


        private void BtnAjouter_Click(object sender, RoutedEventArgs e)
        {
            bool verif = true;
            if (ComboBoxChauffCommun.SelectedIndex == 0)
            {
                verif = true;
            }
            if (ComboBoxChauffCommun.SelectedIndex == 1)
            {
                verif = false;
            }
            bool verif2 = true;
            if (ComboBoxAscenceurCommun.SelectedIndex == 1)
            {
                verif2 = false;
            }
            

            Bien appart = new Appartement(TxtAppartementNom.Text, int.Parse(TxtAppartementValeur.Text), TxtAppartementAdresse.Text, int.Parse(TxtAppartementSurface.Text), int.Parse(TxtAppartementNbPieces.Text), int.Parse(TxtAppartementNbChambres.Text), int.Parse(TxtAppartementNbCaves.Text), int.Parse(TxtAppartementNbParkings.Text), int.Parse(TxtAppartementEtages.Text),verif2, verif);
            cxt.Biens.Add(appart);
            cxt.SaveChanges();

        }

        private void ComboBoxChauffCommun_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
