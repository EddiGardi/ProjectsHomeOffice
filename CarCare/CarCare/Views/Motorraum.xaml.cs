using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

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
            Class.Globals.uebergabe = "Motorraum";


            if (Class.Globals.serviceNew.Motorraum.Luftfilter.Count != 0 && Class.Globals.serviceNew.Motorraum.Luftfilter[0].Frist <= DateTime.Now)
            {
                airFilterBtn.Background = Brushes.Red;
            }
            if (Class.Globals.serviceNew.Motorraum.Öl.Count != 0 && Class.Globals.serviceNew.Motorraum.Öl[0].Frist <= DateTime.Now)
            {
                oilBtn.Background = Brushes.Red;
            }
            if (Class.Globals.serviceNew.Motorraum.Steuerkette.Count != 0 && Class.Globals.serviceNew.Motorraum.Steuerkette[0].Frist <= DateTime.Now)
            {
                timingChainBtn.Background = Brushes.Red;
            }
            if (Class.Globals.serviceNew.Motorraum.Kettenspanner.Count != 0 && Class.Globals.serviceNew.Motorraum.Kettenspanner[0].Frist <= DateTime.Now)
            {
                chainTensionerBtn.Background = Brushes.Red;
            }
            if (Class.Globals.serviceNew.Motorraum.Batterie.Count != 0 && Class.Globals.serviceNew.Motorraum.Batterie[0].Frist <= DateTime.Now)
            {
                batteryBtn.Background = Brushes.Red;
            }
            if (Class.Globals.serviceNew.Motorraum.Zündkerze.Count != 0 && Class.Globals.serviceNew.Motorraum.Zündkerze[0].Frist <= DateTime.Now)
            {
                sparkPlugsBtn.Background = Brushes.Red;
            }
            if (Class.Globals.serviceNew.Motorraum.Bremsflüssigkeit.Count != 0 && Class.Globals.serviceNew.Motorraum.Bremsflüssigkeit[0].Frist <= DateTime.Now)
            {
                brakeFluidBtn.Background = Brushes.Red;
            }
        }

        private void TimingChain_Click(object sender, RoutedEventArgs e)
        {
            Class.Methods.CheckExisting(Class.Globals.uebergabe, "Steuerkette");
            Class.Globals.tempService.Group = Class.Globals.uebergabe;
            Class.Globals.tempService.PartName = "Steuerkette";
            this.NavigationService.Navigate(new InfoPage());
        }

        private void Airfilter_Click(object sender, RoutedEventArgs e)
        {
            Class.Methods.CheckExisting(Class.Globals.uebergabe, "Luftfilter");
            Class.Globals.tempService.Group = Class.Globals.uebergabe;
            Class.Globals.tempService.PartName = "Luftfilter";
            this.NavigationService.Navigate(new InfoPage());
        }

        private void BrakeFluid_Click(object sender, RoutedEventArgs e)
        {
            Class.Methods.CheckExisting(Class.Globals.uebergabe, "Bremsflüssigkeit");
            Class.Globals.tempService.Group = Class.Globals.uebergabe;
            Class.Globals.tempService.PartName = "Bremsflüssigkeit";
            this.NavigationService.Navigate(new InfoPage());
        }

        private void Battery_Click (object sender, RoutedEventArgs e)
        {
            Class.Methods.CheckExisting(Class.Globals.uebergabe, "Batterie");
            Class.Globals.tempService.Group = Class.Globals.uebergabe;
            Class.Globals.tempService.PartName = "Batterie";
            this.NavigationService.Navigate(new InfoPage());
        }

        private void SparkPlugs_Click(object sender, RoutedEventArgs e)
        {
            Class.Methods.CheckExisting(Class.Globals.uebergabe, "Zündkerze");
            Class.Globals.tempService.Group = Class.Globals.uebergabe;
            Class.Globals.tempService.PartName = "Zündkerze";
            this.NavigationService.Navigate(new InfoPage());
        }

        private void ChainTensioner_Click (object sender, RoutedEventArgs e)
        {
            Class.Methods.CheckExisting(Class.Globals.uebergabe, "Kettenspanner");
            Class.Globals.tempService.Group = Class.Globals.uebergabe;
            Class.Globals.tempService.PartName = "Kettenspanner";
            this.NavigationService.Navigate(new InfoPage());
        }

        private void Oil_Click (object sender, RoutedEventArgs e)
        {
            Class.Methods.CheckExisting(Class.Globals.uebergabe, "Öl");
            Class.Globals.tempService.Group = Class.Globals.uebergabe;
            Class.Globals.tempService.PartName = "Öl";
            this.NavigationService.Navigate(new InfoPage());
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Haupt());
        }
    }
}
