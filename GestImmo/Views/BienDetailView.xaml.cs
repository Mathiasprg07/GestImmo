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

namespace GestImmo.Views
{
    /// <summary>
    /// Logique d'interaction pour BienDetailView.xaml
    /// </summary>
    public partial class BienDetailView : Page
    {
        GestImmoContext context = GestImmoContext.getInstance();
        public BienDetailView(int bienID)
        {
            InitializeComponent();
            Bien bien = context.Biens.Find(bienID);

                if(bien is Box)
            {
                this.FrameDetailBien.Navigate(new BoxDetailView((Box)bien));
            }
            else if (bien is Appartement)
            {
                this.FrameDetailBien.Navigate(new AppartementDetailView((Appartement)bien));
            }
            else if (bien is Maison)
            {
                this.FrameDetailBien.Navigate(new MaisonDetailView((Maison)bien));
            }
        }

        private void FrameDetailBien_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
}
