using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

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

            if ((Class.Globals.serviceNew.Motorraum.Luftfilter.Count != 0 && Class.Globals.serviceNew.Motorraum.Luftfilter[0].Frist <= DateTime.Now) ||
                (Class.Globals.serviceNew.Motorraum.Öl.Count != 0 && Class.Globals.serviceNew.Motorraum.Öl[0].Frist <= DateTime.Now) ||
                (Class.Globals.serviceNew.Motorraum.Steuerkette.Count != 0 && Class.Globals.serviceNew.Motorraum.Steuerkette[0].Frist <= DateTime.Now) ||
                (Class.Globals.serviceNew.Motorraum.Kettenspanner.Count != 0 && Class.Globals.serviceNew.Motorraum.Kettenspanner[0].Frist <= DateTime.Now) ||
                (Class.Globals.serviceNew.Motorraum.Batterie.Count != 0 && Class.Globals.serviceNew.Motorraum.Batterie[0].Frist <= DateTime.Now) ||
                (Class.Globals.serviceNew.Motorraum.Zündkerze.Count != 0 && Class.Globals.serviceNew.Motorraum.Zündkerze[0].Frist <= DateTime.Now) ||
                (Class.Globals.serviceNew.Motorraum.Bremsflüssigkeit.Count != 0 && Class.Globals.serviceNew.Motorraum.Bremsflüssigkeit[0].Frist <= DateTime.Now))
            {
                engineBayButton.Background = Brushes.Red;
            }
            if ((Class.Globals.serviceNew.Vorderrad.Reifen.Count != 0 && Class.Globals.serviceNew.Vorderrad.Reifen[0].Frist <= DateTime.Now) ||
                (Class.Globals.serviceNew.Vorderrad.Bremsscheibe.Count != 0 && Class.Globals.serviceNew.Vorderrad.Bremsscheibe[0].Frist <= DateTime.Now) ||
                (Class.Globals.serviceNew.Vorderrad.Bremsbelag.Count != 0 && Class.Globals.serviceNew.Vorderrad.Bremsbelag[0].Frist <= DateTime.Now))
            {
                frontWheelButton.Background = Brushes.Red;
            }
            if ((Class.Globals.serviceNew.Hinterrad.Reifen.Count != 0 && Class.Globals.serviceNew.Hinterrad.Reifen[0].Frist <= DateTime.Now) ||
                (Class.Globals.serviceNew.Hinterrad.Bremsscheibe.Count != 0 && Class.Globals.serviceNew.Hinterrad.Bremsscheibe[0].Frist <= DateTime.Now) ||
                (Class.Globals.serviceNew.Hinterrad.Bremsbelag.Count != 0 && Class.Globals.serviceNew.Hinterrad.Bremsbelag[0].Frist <= DateTime.Now))
            {
                rearWheelButton.Background = Brushes.Red;
            }
            if (Class.Globals.serviceNew.Innenraum.Innenraumfilter.Count != 0 && Class.Globals.serviceNew.Innenraum.Innenraumfilter[0].Frist <= DateTime.Now)
            {
                interiorButton.Background = Brushes.Red;
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
