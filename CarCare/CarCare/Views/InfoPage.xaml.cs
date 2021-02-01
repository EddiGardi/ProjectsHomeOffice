using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace CarCare.Views
{
    /// <summary>
    /// Interaktionslogik für InfoPage.xaml
    /// </summary>
    public partial class InfoPage : Page
    {
        Class.Part selected;

        public InfoPage()
        {
            InitializeComponent();
            dg_serviceList.ItemsSource = Class.Globals.serviceList;
            if (Class.Globals.exists)
            {
                group.Text = Class.Globals.tempService.Group;
                partname.Text = Class.Globals.tempService.PartName;
                changein.Text = Class.Globals.serviceList[0].Frist.ToString("dd.MM.yyyy");
                changelast.Text = Class.Globals.serviceList[0].Zuletzt.ToString("dd.MM.yyyy");
                odo.Text = Class.Globals.serviceList[0].Kilometerstand.ToString();
                infos.Text = Class.Globals.serviceList[0].Info;
            }
            else
            {
                bearbeiten.IsEnabled = false;
                loeschen.IsEnabled = false;
                group.Text = Class.Globals.tempService.Group;
                partname.Text = Class.Globals.tempService.PartName;
                changelast.Text = "Als MM/DD/YY eingeben";
                odo.Text = "";
                infos.Text = "";
            }
        }

        private void Bearbeiten_Click(object sender, RoutedEventArgs e)
        {
            if (selected != null)
            {
                Class.Globals.serviceList.Remove(selected);
                selected = new Class.Part (Class.Globals.serviceList.Count + 1,  DateTime.Parse(changelast.Text), Convert.ToInt32(odo.Text), infos.Text );
                Class.Globals.serviceList.Add(selected);
            }
        }

        private void Hinzufuegen_Click(object sender, RoutedEventArgs e)
        {
            Class.Part service = new Class.Part (0, DateTime.Parse(changelast.Text), Convert.ToInt32(odo.Text), infos.Text );

            //Class.Methods.NewEntry(group.Text, partname.Text, DateTime.Parse(changelast.Text), Convert.ToInt32(odo.Text), infos.Text);

            if (Class.Globals.serviceList.Count == 0)
            {
                Class.Globals.serviceList = new System.Collections.ObjectModel.ObservableCollection<Class.Part> { service };
                dg_serviceList.ItemsSource = Class.Globals.serviceList;
                bearbeiten.IsEnabled = true;
                loeschen.IsEnabled = true;
            }
            else Class.Globals.serviceList.Add(service);
        }

        private void Loeschen_Click(object sender, RoutedEventArgs e)
        {
            if (selected != null)
            {
                if (Class.Globals.serviceList.Count == 1)
                {
                    bearbeiten.IsEnabled = false;
                    loeschen.IsEnabled = false;
                    dg_serviceList.ItemsSource = null;
                    Class.Globals.serviceList = new System.Collections.ObjectModel.ObservableCollection<Class.Part>();
                }
                else Class.Globals.serviceList.Remove(selected);
                selected = null;
            }
        }

        private void Schließen_Click(object sender, RoutedEventArgs e)
        {
            List<Class.Part> sortedList = Class.Globals.serviceList.OrderByDescending(s => s.Zuletzt).ToList();
            if (Class.Globals.serviceList.Count != 0)
            {
                int num = 1;
                foreach (Class.Part item in sortedList)
                {
                    item.Eintrag = num++;
                }
            }
            Class.Methods.SortedClose(group.Text, partname.Text, sortedList);
            Class.Globals.serviceList = null;
            if (Class.Globals.uebergabe == "Hinterrad") this.NavigationService.Navigate(new Hinterreifen());
            else if (Class.Globals.uebergabe == "Vorderrad") this.NavigationService.Navigate(new Vorderreifen());
            else if (Class.Globals.uebergabe == "Innenraum") this.NavigationService.Navigate(new Innenraum());
            else this.NavigationService.Navigate(new Motorraum());
        }

        private void Dg_serviceList_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            selected = (Class.Part)dg_serviceList.SelectedItem;
            if (selected != null)
            {
                changelast.Text = selected.Zuletzt.ToString();
                changein.Text = selected.Frist.ToString("dd.MM.yyyy");
                odo.Text = selected.Kilometerstand.ToString();
                infos.Text = selected.Info;
               // InitializeComponent();
            }
        }
    }
}
