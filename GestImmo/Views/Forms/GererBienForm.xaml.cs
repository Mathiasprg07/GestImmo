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
using GestImmo.Views.Forms;
using GestImmo.DATA.Models;
using GestImmo.Views.Tools;

namespace GestImmo.Views.Forms
{
    /// <summary>
    /// Logique d'interaction pour GererBienForm.xaml
    /// </summary>
    public partial class GererBienForm : Page
    {
        private IObserver obs;

        private void TypeBien_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (TypeBien.SelectedIndex == 0)
            {
                initAjouterBox();
            }
            if (TypeBien.SelectedIndex == 1)
            {
                initAjouterMaison();
            }
            if (TypeBien.SelectedIndex == 2)
            {
                initAjouterAppart();            }
        }
        public GererBienForm(IObserver obs)
        {
            InitializeComponent();
            this.obs = obs;
        }

        private void initAjouterBox()
        {
            GererBoxForm boxForm = new GererBoxForm();

            if (this.obs != null)
            {
                boxForm.Observers.Add(this.obs);
            }
            this.FrameAfficheForm.Navigate(boxForm);

        }

        private void initAjouterMaison()
        {
            GererMaison maisonForm = new GererMaison();

            if (this.obs != null)
            {
                maisonForm.Observers.Add(this.obs);
            }
            this.FrameAfficheForm.Navigate(maisonForm);

        }

        private void initAjouterAppart()
        {
            GererAppartement appartementForm = new GererAppartement();

            if (this.obs != null)
            {
                appartementForm.Observers.Add(this.obs);
            }
            this.FrameAfficheForm.Navigate(appartementForm);

        }


        private void FrameAfficheForm_Navigated(object sender, NavigationEventArgs e)
        {

        }

    }
}
