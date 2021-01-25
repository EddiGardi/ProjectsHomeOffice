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
    /// Interaktionslogik für InfoPage.xaml
    /// </summary>
    public partial class InfoPage : Page
    {
        public InfoPage()
        {
            InitializeComponent();
            if (Globals.vorhanden)
            {
                hinzufuegen.IsEnabled = false;
                group.Text = Globals.service[Globals.i].Group;
                partname.Text = Globals.service[Globals.i].PartName;
                changein.Text = Globals.service[Globals.i].ChangingDate.ToString();
                changelast.Text = Globals.service[Globals.i].ChangedLast.ToString();
                odo.Text = Globals.service[Globals.i].Odometer.ToString();
                infos.Text = Globals.service[Globals.i].MoreInfos;
            }
            else
            {
                bearbeiten.IsEnabled = false;
                loeschen.IsEnabled = false;
                group.Text = "Motorrraum / Vorderrreifen / Hinterreifen / Innenraum";
                partname.Text = "Teilenamen eingeben";
                changelast.Text = "Als MM/DD/YY eingeben";
                odo.Text = "";
                infos.Text = "";
            }
        }

        private void Bearbeiten_Click(object sender, RoutedEventArgs e)
        {
            Globals.service[Globals.i].Group = group.Text;
            Globals.service[Globals.i].PartName = partname.Text;
            Globals.service[Globals.i].ChangedLast = DateTime.Parse(changelast.Text);
            Globals.service[Globals.i].ChangingDate = Globals.service[Globals.i].ChangedLast.AddYears(2);
            Globals.service[Globals.i].Odometer = Convert.ToInt32(odo.Text);
            Globals.service[Globals.i].MoreInfos = infos.Text;
        }
        private void Hinzufuegen_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Loeschen_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Schließen_Click(object sender, RoutedEventArgs e)
        {
            if (Globals.uebergabe == "h") this.NavigationService.Navigate(new Hinterreifen());
            else if (Globals.uebergabe == "v") this.NavigationService.Navigate(new Vorderreifen());
            else if (Globals.uebergabe == "i") this.NavigationService.Navigate(new Innenraum());
            else this.NavigationService.Navigate(new Motorraum());
        }
    }
}
