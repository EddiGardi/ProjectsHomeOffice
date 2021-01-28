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
using Newtonsoft.Json;
using System.IO;

namespace CarCare
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainView_Loaded;
        }

        private void MainView_Loaded (object sender, RoutedEventArgs e)
        {
            frame.NavigationService.Navigate(new Views.Haupt());
        }

        private void EngineBay_Loaded(object sender, RoutedEventArgs e)
        {
            frame.NavigationService.Navigate(new Views.Motorraum());
        }

        private void FrontWheel_Loaded(object sender, RoutedEventArgs e)
        {
            frame.NavigationService.Navigate(new Views.Vorderreifen());
        }

        private void RearWheel_Loaded(object sender, RoutedEventArgs e)
        {
            frame.NavigationService.Navigate(new Views.Hinterreifen());
        }

        private void Interior_Loaded(object sender, RoutedEventArgs e)
        {
            frame.NavigationService.Navigate(new Views.Innenraum());
        }

        private void Overview_Loaded(object sender, RoutedEventArgs e)
        {
            frame.NavigationService.Navigate(new Views.Überblick());
        }

        private void Save_Click (object sender, RoutedEventArgs e)
        {
            File.Delete(Globals.path);

            using (var file = File.CreateText(Globals.path))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, Globals.service);
            }
            MessageBox.Show("Datei gespeichert.");
        }
    }
}
