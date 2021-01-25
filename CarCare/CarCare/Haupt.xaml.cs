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

namespace CarCare
{
    /// <summary>
    /// Interaktionslogik für Haupt.xaml
    /// </summary>
    public partial class Haupt : Page
    {
        public Haupt()
        {
            InitializeComponent();
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
