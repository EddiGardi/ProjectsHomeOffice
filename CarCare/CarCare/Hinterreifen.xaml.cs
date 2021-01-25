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
    /// Interaktionslogik für Hinterreifen.xaml
    /// </summary>
    public partial class Hinterreifen : Page
    {
        public Hinterreifen()
        {
            InitializeComponent();
            Globals.uebergabe = "h";
            Globals.i = 0;
            Globals.vorhanden = false;
        }

        private void BrakeDisc_Click(object sender, RoutedEventArgs e)
        {
            if (Globals.service != null)
            {
                while (Globals.service[Globals.i].Group != "Hinterreifen" && Globals.service[Globals.i].PartName != "Bremsscheibe" && Globals.i <= Globals.service.Count)
                {
                    Globals.i++;
                }
                if (Globals.service[Globals.i].Group != "Hinterreifen" && Globals.service[Globals.i].PartName != "Bremsscheibe")
                {
                    MessageBox.Show("Es ist noch nichts für die Bremsscheibe Hinten angelegt.");
                }
                else
                {
                    Globals.vorhanden = true;
                }
            }
            else
            {
                MessageBox.Show("Es ist noch nichts angelegt.");
            }
            this.NavigationService.Navigate(new InfoPage());
        }

        private void BrakePad_Click(object sender, RoutedEventArgs e)
        {
            if (Globals.service != null)
            {
                while (Globals.service[Globals.i].Group != "Hinterreifen" && Globals.service[Globals.i].PartName != "Bremsbelag" && Globals.i <= Globals.service.Count)
                {
                    Globals.i++;
                }
                if (Globals.service[Globals.i].Group != "Hinterreifen" && Globals.service[Globals.i].PartName != "Bremsbelag")
                {
                    MessageBox.Show("Es ist noch nichts für die Bremsbelag Hinten angelegt.");
                }
                else
                {
                    Globals.vorhanden = true;
                }
            }
            else
            {
                MessageBox.Show("Es ist noch nichts angelegt.");
            }
            this.NavigationService.Navigate(new InfoPage());
        }

        private void Tire_Click(object sender, RoutedEventArgs e)
        {
            if (Globals.service != null)
            {
                while (Globals.service[Globals.i].Group != "Hinterreifen" && Globals.service[Globals.i].PartName != "Reifen" && Globals.i <= Globals.service.Count)
                {
                    Globals.i++;
                }
                if (Globals.service[Globals.i].Group != "Hinterreifen" && Globals.service[Globals.i].PartName != "Reifen")
                {
                    MessageBox.Show("Es ist noch nichts für die Reifen Hinten angelegt.");
                }
                else
                {
                    Globals.vorhanden = true;
                }
            }
            else
            {
                MessageBox.Show("Es ist noch nichts angelegt.");
            }
            this.NavigationService.Navigate(new InfoPage());
        }
    }
}
