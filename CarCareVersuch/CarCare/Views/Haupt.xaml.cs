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

namespace CarCare.Views
{
    /// <summary>
    /// Interaktionslogik für Haupt.xaml
    /// </summary>
    public partial class Haupt : Page
    {
        public Haupt()
        {
            InitializeComponent();
            // &&
            if (Globals.service.Find(s => s.Group == "Motorraum") != null) 
            {
                /*if (Globals.service.FirstOrDefault(service => (service.Group == "Motorraum") && (service.PartName == "Zündkerzen und -spulen")).ChangingDate <= DateTime.Now 
                    || Globals.service.FirstOrDefault(service => (service.Group == "Motorraum") && (service.PartName == "Öl")).ChangingDate <= DateTime.Now
                    || Globals.service.FirstOrDefault(service => (service.Group == "Motorraum") && (service.PartName == "Luftfilter")).ChangingDate <= DateTime.Now
                    || Globals.service.FirstOrDefault(service => (service.Group == "Motorraum") && (service.PartName == "Steuerkette")).ChangingDate <= DateTime.Now
                    || Globals.service.FirstOrDefault(service => (service.Group == "Motorraum") && (service.PartName == "Kettenspanner")).ChangingDate <= DateTime.Now
                    || Globals.service.FirstOrDefault(service => (service.Group == "Motorraum") && (service.PartName == "Batterie")).ChangingDate <= DateTime.Now
                    || Globals.service.FirstOrDefault(service => (service.Group == "Motorraum") && (service.PartName == "Bremsflüssigkeit")).ChangingDate <= DateTime.Now)
                    // Null Überprüfung
                    */
                {
                    engineBayButton.Background = Brushes.Red;
                }

            }
            if (Globals.service.Find(service => (service.Group == "Innenraum") && (service.ChangingDate <= DateTime.Now)) != null)
            {
                interiorButton.Background = Brushes.Red;
            }
            if (Globals.service.Find(service => (service.Group == "Vorderreifen") && (service.ChangingDate <= DateTime.Now)) != null)
            {
                frontWheelButton.Background = Brushes.Red;
            }
            if (Globals.service.Find(service => (service.Group == "Hinterreifen") && (service.ChangingDate <= DateTime.Now)) != null)
            {
                rearWheelButton.Background = Brushes.Red;
            }
        }

        private void OpenEngineBay_Click (object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Motorraum());
        }
        private void OpenWheelsFront_Click (object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Vorderreifen());
        }
        private void OpenWheelsRear_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Hinterreifen());
        }
        private void OpenInterior_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Innenraum());
        }
    }
}
