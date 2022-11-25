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

        public BienView()
        {
            InitializeComponent();

            //Bien box = new Box("test", 20, "adresse", 20);
            //gestImmocontext.Biens.Add(box);
            //gestImmocontext.SaveChanges();
            foreach (Bien item in gestImmocontext.Biens)
            {
                this.ListeBiens.Items.Add(item.Nom);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.FrameBienAjouter.Navigate(new GererBienForm());
        }
        private void ListeBien1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private void Double_Click(object sender, MouseButtonEventArgs e)
        {
            BienSingleView objetBien = new BienSingleView();
            this.FrameBienAjouter.Navigate(objetBien);
            string variable = (string)ListeBiens.SelectedItems[0];

            foreach (Bien bien in gestImmocontext.Biens)
            {
                if (bien.Nom == variable)
                {

                    objetBien.ListAffichage.Items.Add(bien.Nom);
                    objetBien.ListAffichage.Items.Add(bien.Valeur);
                    objetBien.ListAffichage.Items.Add(bien.Adresse);
                    objetBien.ListAffichage.Items.Add(bien.Surface);


                }
            }
        }

        private void ListeBiens_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}

