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
using GestImmo.Views.Tools;

namespace GestImmo.Views.Forms
{
    /// <summary>
    /// Logique d'interaction pour GererMaison.xaml
    /// </summary>
    public partial class GererMaison : Page, IObservable
    {
        GestImmoContext ctx = GestImmoContext.getInstance();
        public List<IObserver> Observers { get; set; }
        public GererMaison()
        {
            InitializeComponent();
            Observers = new List<IObserver>();

        }

        private void BtnAjouter_Click(object sender, RoutedEventArgs e)
        {
            Bien maison = new Maison(TxtMaisonNom.Text, int.Parse(TxtMaisonValeur.Text), TxtMaisonAdresse.Text, int.Parse(TxtMaisonSurface.Text), int.Parse(TxtMaisonNbPieces.Text), int.Parse(TxtMaisonNbChambres.Text), int.Parse(TxtMaisonNbCaves.Text), int.Parse(TxtMaisonNbParkings.Text));
            ctx.Biens.Add(maison);
            ctx.SaveChanges();
            this.notifyObservers();

        }

        void notifyObservers()
        {
            foreach (IObserver obs in Observers)
            {
                obs.update();
            }
        }
    }
}
