using System.Windows;
using Newtonsoft.Json;

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
            using (var file = System.IO.File.CreateText(Class.Globals.path))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, Class.Globals.serviceNew);
            }
            MessageBox.Show("Datei gespeichert.");
        }
    }
}
