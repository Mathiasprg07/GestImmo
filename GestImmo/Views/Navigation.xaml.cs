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
    /// Logique d'interaction pour Navigation.xaml
    /// </summary>
    public partial class Navigation : Page
    {
        public Navigation()
        {
            InitializeComponent();
            this.FrameNavigation.Navigate(new HomeView());
        }

        private void Biens_Click(object sender, RoutedEventArgs e)
        {
            this.FrameNavigation.Navigate(new BienView());
        }



        private void Prets_Click(object sender, RoutedEventArgs e)
        {
            this.FrameNavigation.Navigate(new PretView());
        }

        private void Acceuil_Click(object sender, RoutedEventArgs e)
        {
            this.FrameNavigation.Navigate(new HomeView());
        }

        private void BtnPrestataire_Click(object sender, RoutedEventArgs e)
        {
            this.FrameNavigation.Navigate(new PrestataireView());
        }
    }
}
