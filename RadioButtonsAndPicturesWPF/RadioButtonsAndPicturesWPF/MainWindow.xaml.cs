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

namespace RadioButtonsAndPicturesWPF
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Yes_RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Danke, dass du ja gesagt hast.");
        }
        private void No_RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Schade, dass du nein gesagt hast.");
        }
        private void Maybe_RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hmm. Du hast vielleicht gesagt.");
        }
    }
}
