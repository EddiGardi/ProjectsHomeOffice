using System.Windows;
using System.Windows.Controls;

namespace CarCare.Views
{
    /// <summary>
    /// Interaktionslogik für Hinterreifen.xaml
    /// </summary>
    public partial class Hinterreifen : Page
    {
        public Hinterreifen()
        {
            InitializeComponent();
            Class.Globals.uebergabe = "Hinterrad";
        }

        private void BrakeDisc_Click(object sender, RoutedEventArgs e)
        {
            Class.Methods.CheckExisting (Class.Globals.uebergabe, "Bremsscheibe");
            Class.Globals.tempService.Group = Class.Globals.uebergabe;
            Class.Globals.tempService.PartName = "Bremsscheibe";
            this.NavigationService.Navigate(new InfoPage());
        }

        private void BrakePad_Click(object sender, RoutedEventArgs e)
        {
            Class.Methods.CheckExisting(Class.Globals.uebergabe, "Bremsbelag");
            Class.Globals.tempService.Group = Class.Globals.uebergabe;
            Class.Globals.tempService.PartName = "Bremsbelag";
            this.NavigationService.Navigate(new InfoPage());
        }

        private void Tire_Click(object sender, RoutedEventArgs e)
        {
            Class.Methods.CheckExisting(Class.Globals.uebergabe, "Reifen");
            Class.Globals.tempService.Group = Class.Globals.uebergabe;
            Class.Globals.tempService.PartName = "Reifen";
            this.NavigationService.Navigate(new InfoPage());
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Haupt());
        }
    }
}
