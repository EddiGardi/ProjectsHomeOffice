using System.Windows;
using System.Windows.Controls;

namespace CarCare.Views
{
    /// <summary>
    /// Interaktionslogik für Innenraum.xaml
    /// </summary>
    public partial class Innenraum : Page
    {
        public Innenraum()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Haupt());
        }
    }
}
