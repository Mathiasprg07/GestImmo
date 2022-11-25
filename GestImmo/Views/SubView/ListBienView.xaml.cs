using ConsoleApp.PostgreSQL;
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
using GestImmo.DATA.Models;
using GestImmo.Views.Tools;

namespace GestImmo.Views.SubView
{
    /// <summary>
    /// Logique d'interaction pour ListBienView.xaml
    /// </summary>
    public partial class ListBienView : Page, IObserver
    {
        GestImmoContext gestImmocontext = GestImmoContext.getInstance();

        public ListBienView()
        {
            InitializeComponent();

        }
        
        private void refreshList()
        {
            GestImmoContext ctx = GestImmoContext.getInstance();

            this.ListeBien.Items.Clear();

            foreach (Bien bien in ctx.Biens)
            {
                this.ListeBien.Items.Add(bien.Nom);
            }
        }
       
        public void update()
        {
            this.refreshList();
        }
        

        private void ListeBien_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MessageBox.Show("Bien joué");



        }
    }
}
