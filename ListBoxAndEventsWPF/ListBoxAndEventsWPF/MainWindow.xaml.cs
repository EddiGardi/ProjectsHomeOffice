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

namespace ListBoxAndEventsWPF
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Match> matches = new List<Match>();
            matches.Add(new Match() { Team1 = "Bayern München", Team2 = "Real Madrid", Score1 = 3, Score2 = 1, Completion = 85 });
            matches.Add(new Match() { Team1 = "HSV", Team2 = "Werder Bremen", Score1 = 0, Score2 = 0, Completion = 35 });
            matches.Add(new Match() { Team1 = "PSG", Team2 = "Ajax", Score1 = 3, Score2 = 0, Completion = 20 });
            matches.Add(new Match() { Team1 = "Zenit Moskau", Team2 = "RB Leipzig", Score1 = 0, Score2 = 1, Completion = 10 });

            lbMatches.ItemsSource = matches;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (lbMatches.SelectedItem != null )
            {
                MessageBox.Show("Ausgewähltes Spiel:" + "\n"
                     + (lbMatches.SelectedItem as Match).Team1 + " gegen "
                     + (lbMatches.SelectedItem as Match).Team2 + " mit dem Spielstand "
                     + (lbMatches.SelectedItem as Match).Score1 + ":"
                     + (lbMatches.SelectedItem as Match).Score2 + "." + "\n"
                     + "Sie befinden sich in der " + (lbMatches.SelectedItem as Match).Completion + ". Spielminute.");
            }
        }
    }
}
