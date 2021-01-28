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
    /// Interaktionslogik für Vorderreifen.xaml
    /// </summary>
    public partial class Vorderreifen : Page
    {
        public string SourceUri { get; set; } 

        public Vorderreifen()
        {
            InitializeComponent();
            Globals.uebergabe = "Vorderreifen";
        }

        private void BrakeDisc_Click(object sender, RoutedEventArgs e)
        {
            Globals.CheckExisting(Globals.uebergabe, "Bremsscheibe");
            Globals.tempService.Group = Globals.uebergabe;
            Globals.tempService.PartName = "Bremsscheibe";
            this.NavigationService.Navigate(new InfoPage());
        }

        private void BrakePad_Click(object sender, RoutedEventArgs e)
        {
            Globals.CheckExisting(Globals.uebergabe, "Bremsbelag");
            Globals.tempService.Group = Globals.uebergabe;
            Globals.tempService.PartName = "Bremsbelag";
            this.NavigationService.Navigate(new InfoPage());
        }

        private void Tire_Click(object sender, RoutedEventArgs e)
        {
            Globals.CheckExisting(Globals.uebergabe, "Reifen");
            Globals.tempService.Group = Globals.uebergabe;
            Globals.tempService.PartName = "Reifen";
            this.NavigationService.Navigate(new InfoPage());
        }

        private void Back_Click (object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Haupt());
        }
    }
}
