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
using System.IO;

namespace CarCare.Views
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
            if (Globals.service.Find(service => service.PartName == "Steuerkette") != null && Globals.service.Find(service => service.PartName == "Steuerkette").ChangingDate <= DateTime.Now)
            {
                timingChainBtn.Background = Brushes.Red;
            }
            if (Globals.service.Find(service => service.PartName == "Luftfilter") != null && Globals.service.Find(service => service.PartName == "Luftfilter").ChangingDate <= DateTime.Now)
            {
                airFilterBtn.Background = Brushes.Red;
            }
            if (Globals.service.Find(service => service.PartName == "Bremsflüssigkeit") != null && Globals.service.Find(service => service.PartName == "Bremsflüssigkeit").ChangingDate <= DateTime.Now)
            {
                brakeFluidBtn.Background = Brushes.Red;
            }
            if (Globals.service.Find(service => service.PartName == "Batterie") != null && Globals.service.Find(service => service.PartName == "Batterie").ChangingDate <= DateTime.Now)
            {
                batteryBtn.Background = Brushes.Red;
            }
            if (Globals.service.Find(service => service.PartName == "Zündkerzen und -spulen") != null && Globals.service.Find(service => service.PartName == "Zündkerzen und -spulen").ChangingDate <= DateTime.Now)
            {
                sparkPlugsBtn.Background = Brushes.Red;
            }
            if (Globals.service.Find(service => service.PartName == "Kettenspanner") != null && Globals.service.Find(service => service.PartName == "Kettenspanner").ChangingDate <= DateTime.Now)
            {
                chainTensionerBtn.Background = Brushes.Red;
            }
            if (Globals.service.Find(service => service.PartName == "Öl") != null && Globals.service.Find(service => service.PartName == "Öl").ChangingDate <= DateTime.Now)
            {
                oilBtn.Background = Brushes.Red;
            }
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
