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
    /// Interaktionslogik für Motorraum.xaml
    /// </summary>
    public partial class Motorraum : Page
    {
        public Motorraum()
        {
            InitializeComponent();
            Globals.uebergabe = "Motorraum";
        }

        private void TimingChain_Click(object sender, RoutedEventArgs e)
        {
            Globals.CheckExisting(Globals.uebergabe, "Steuerkette");
            Globals.tempService.Group = Globals.uebergabe;
            Globals.tempService.PartName = "Steuerkette";
            this.NavigationService.Navigate(new InfoPage());
        }

        private void Airfilter_Click(object sender, RoutedEventArgs e)
        {
            Globals.CheckExisting(Globals.uebergabe, "Luftfilter");
            Globals.tempService.Group = Globals.uebergabe;
            Globals.tempService.PartName = "Luftfilter";
            this.NavigationService.Navigate(new InfoPage());
        }

        private void BrakeFluid_Click(object sender, RoutedEventArgs e)
        {
            Globals.CheckExisting(Globals.uebergabe, "Bremsflüssigkeit");
            Globals.tempService.Group = Globals.uebergabe;
            Globals.tempService.PartName = "Bremsflüssigkeit";
            this.NavigationService.Navigate(new InfoPage());
        }

        private void Battery_Click (object sender, RoutedEventArgs e)
        {
            Globals.CheckExisting(Globals.uebergabe, "Batterie");
            Globals.tempService.Group = Globals.uebergabe;
            Globals.tempService.PartName = "Batterie";
            this.NavigationService.Navigate(new InfoPage());
        }

        private void SparkPlugs_Click(object sender, RoutedEventArgs e)
        {
            Globals.CheckExisting(Globals.uebergabe, "Zündkerzen und -spulen");
            Globals.tempService.Group = Globals.uebergabe;
            Globals.tempService.PartName = "Zündkerzen und -spulen";
            this.NavigationService.Navigate(new InfoPage());
        }

        private void ChainTensioner_Click (object sender, RoutedEventArgs e)
        {
            Globals.CheckExisting(Globals.uebergabe, "Kettenspanner");
            Globals.tempService.Group = Globals.uebergabe;
            Globals.tempService.PartName = "Kettenspanner";
            this.NavigationService.Navigate(new InfoPage());
        }

        private void Oil_Click (object sender, RoutedEventArgs e)
        {
            Globals.CheckExisting(Globals.uebergabe, "Öl");
            Globals.tempService.Group = Globals.uebergabe;
            Globals.tempService.PartName = "Öl";
            this.NavigationService.Navigate(new InfoPage());
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Haupt());
        }
    }
}
