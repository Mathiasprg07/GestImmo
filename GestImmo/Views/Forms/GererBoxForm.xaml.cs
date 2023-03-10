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
    /// Logique d'interaction pour GererBoxForm.xaml
    /// </summary>
    public partial class GererBoxForm : Page, IObservable
    {
        GestImmoContext context = GestImmoContext.getInstance();

        public GererBoxForm()
        {
            InitializeComponent();
            Observers = new List<IObserver>();
        }
        public List<IObserver> Observers { get; set; }
        private void BtnAjouter_Click(object sender, RoutedEventArgs e)
        {
            Bien bien = new Box(TxtBoxNom.Text, int.Parse(TxtBoxValeur.Text), TxtBoxAdresse.Text, int.Parse(TxtBoxSurface.Text));
            context.Biens.Add(bien);
            context.SaveChanges();
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
