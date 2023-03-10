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
    /// Logique d'interaction pour BoxDetailView.xaml
    /// </summary>
    public partial class BoxDetailView : Page
    {
        public BoxDetailView(Box box)
        {
            InitializeComponent();
            TxtBoxNom.Text = box.Nom;
            TxtBoxValeur.Text = box.Valeur.ToString();
            TxtBoxAdresse.Text = box.Adresse;
            TxtBoxSurface.Text = box.Surface.ToString();




        }

        private void TxtBoxNom_TextChanged(object sender, TextChangedEventArgs e)
        {
           
        }

        private void TxtBoxValeur_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TxtBoxAdresse_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TxtBoxSurface_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}