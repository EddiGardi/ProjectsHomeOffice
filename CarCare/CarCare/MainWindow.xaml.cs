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


public static class Globals
{
    public static int i = 0;
    public static bool vorhanden = false;
    public static string uebergabe = "";
    public static List<Service> service = JsonConvert.DeserializeObject<List<Service>>(File.ReadAllText(@"C:\Users\Edgard Frank\source\repos\CarCare\Datenbank\Service.json"));
}


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
            frame.NavigationService.Navigate(new Haupt());
        }

        private void EngineBay_Loaded(object sender, RoutedEventArgs e)
        {
            frame.NavigationService.Navigate(new Motorraum());
        }
        private void FrontWheel_Loaded(object sender, RoutedEventArgs e)
        {
            frame.NavigationService.Navigate(new Vorderreifen());
        }
        private void RearWheel_Loaded(object sender, RoutedEventArgs e)
        {
            frame.NavigationService.Navigate(new Hinterreifen());
        }
        private void Interior_Loaded(object sender, RoutedEventArgs e)
        {
            frame.NavigationService.Navigate(new Innenraum());
        }
        private void Overview_Loaded(object sender, RoutedEventArgs e)
        {
            frame.NavigationService.Navigate(new Motorraum());
        }
    }
}
