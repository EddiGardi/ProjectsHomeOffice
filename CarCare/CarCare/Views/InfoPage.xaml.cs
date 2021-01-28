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
    /// Interaktionslogik für InfoPage.xaml
    /// </summary>
    public partial class InfoPage : Page
    {
        Service selected;

        public InfoPage()
        {
            InitializeComponent();
            dg_serviceList.ItemsSource = Globals.serviceList;
            if (Globals.exists)
            {
                group.Text = Globals.serviceList[0].Group;
                partname.Text = Globals.serviceList[0].PartName;
                changein.Text = Globals.serviceList[0].ChangingDate.ToString("dd.MM.yyyy");
                changelast.Text = Globals.serviceList[0].ChangedLast.ToString("dd.MM.yyyy");
                odo.Text = Globals.serviceList[0].Odometer.ToString();
                infos.Text = Globals.serviceList[0].MoreInfos;
            }
            else
            {
                bearbeiten.IsEnabled = false;
                loeschen.IsEnabled = false;
                group.Text = Globals.tempService.Group;
                partname.Text = Globals.tempService.PartName;
                changelast.Text = "Als MM/DD/YY eingeben";
                odo.Text = "";
                infos.Text = "";
            }
        }

        private void Bearbeiten_Click(object sender, RoutedEventArgs e)
        {
            if (selected != null)
            {
                Globals.serviceList.Remove(selected);
                selected = new Service(group.Text, partname.Text, DateTime.Parse(changelast.Text), Convert.ToInt32(odo.Text), infos.Text);
                Globals.serviceList.Add(selected);
            }
        }

        private void Hinzufuegen_Click(object sender, RoutedEventArgs e)
        {
            var service = new Service(group.Text, partname.Text, DateTime.Parse(changelast.Text), Convert.ToInt32(odo.Text), infos.Text);

            if (Globals.serviceList is null)
            {
                Globals.serviceList = new System.Collections.ObjectModel.ObservableCollection<Service> { service };
                dg_serviceList.ItemsSource = Globals.serviceList;
                bearbeiten.IsEnabled = true;
                loeschen.IsEnabled = true;
            }
            else Globals.serviceList.Add(service);
        }

        private void Loeschen_Click(object sender, RoutedEventArgs e)
        {
            if (selected != null)
            {
                Globals.serviceList.Remove(selected);
                selected = null;
            }
            if (Globals.serviceList.Count == 0)
            {
                bearbeiten.IsEnabled = false;
                loeschen.IsEnabled = false;
                dg_serviceList.ItemsSource = null;
                Globals.serviceList = null;
            }
        }

        private void Schließen_Click(object sender, RoutedEventArgs e)
        {
            if (Globals.serviceList != null)
            {
                List<Service> sortedList = Globals.serviceList.OrderByDescending(s => s.ChangingDate).ToList();
                Globals.service.AddRange(sortedList);
            }
            Globals.serviceList = null;
            if (Globals.uebergabe == "Hinterreifen") this.NavigationService.Navigate(new Hinterreifen());
            else if (Globals.uebergabe == "Vorderreifen") this.NavigationService.Navigate(new Vorderreifen());
            else if (Globals.uebergabe == "Innenraum") this.NavigationService.Navigate(new Innenraum());
            else this.NavigationService.Navigate(new Motorraum());
        }

        private void Dg_serviceList_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            selected = (Service)dg_serviceList.SelectedItem;
            if (selected != null)
            {
                group.Text = selected.Group;
                partname.Text = selected.PartName;
                changelast.Text = selected.ChangedLast.ToString();
                changein.Text = selected.ChangingDate.ToString("dd.MM.yyyy");
                odo.Text = selected.Odometer.ToString();
                infos.Text = selected.MoreInfos;
                InitializeComponent();
            }
        }
    }
}
