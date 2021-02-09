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
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace DatenbankenZooManagementWPF
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SqlConnection sqlConnection;

        public MainWindow()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["DatenbankenZooManagementWPF.Properties.Settings.FranksDBConnectionString"].ConnectionString;
            sqlConnection = new SqlConnection(connectionString);
            ShowZoos();
            ShowAnimals();
        }

        public void ShowZoos()
        {
            try
            {
                string query = "select * from Zoo";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);

                using (sqlDataAdapter)
                {
                    DataTable zooTable = new DataTable();
                    sqlDataAdapter.Fill(zooTable);

                    // Welche Informationenn der Tabelle in userem DataTable soll in der ListBox angezeigt werden
                    listZoos.DisplayMemberPath = "Location";
                    // Welcher Wert soll gegeben werden, wenn eines unsere Items von der Listbox ausgewählt wird.
                    listZoos.SelectedValuePath = "Id";
                    //
                    listZoos.ItemsSource = zooTable.DefaultView;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void ShowAnimals()
        {
            try
            {
                string query = "select * from Animal";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);

                using (sqlDataAdapter)
                {
                    DataTable animalTable = new DataTable();
                    sqlDataAdapter.Fill(animalTable);

                    listAnimals.DisplayMemberPath = "Name";
                    listAnimals.SelectedValuePath = "Id";
                    listAnimals.ItemsSource = animalTable.DefaultView;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }    
        }

        public void ShowPresentAnimals()
        {
            if (listZoos.SelectedValue == null)
            {
                listPresentAnimals.ItemsSource = null;
                return;
            }

            try
            {
                string query = "select * from Animal a inner join ZooAnimal za on a.Id = za.AnimalId where za.ZooId = @ZooId";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                using (sqlDataAdapter)
                {
                    sqlCommand.Parameters.AddWithValue("@ZooId", listZoos.SelectedValue);

                    DataTable presentAnimalsTable = new DataTable();
                    sqlDataAdapter.Fill(presentAnimalsTable);

                    // Welche Informationenn der Tabelle in userem DataTable soll in der ListBox angezeigt werden
                    listPresentAnimals.DisplayMemberPath = "Name";
                    // Welcher Wert soll gegeben werden, wenn eines unsere Items von der Listbox ausgewählt wird.
                    listPresentAnimals.SelectedValuePath = "Id";
                    //
                    listPresentAnimals.ItemsSource = presentAnimalsTable.DefaultView;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("b");
            }
        }

        private void listZoos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ShowPresentAnimals();
            ShowSelectedZooInTextBox();
        }

        private void listAnimals_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ShowSelectedAnimalInTextBox();
        }
        
        private void ShowSelectedZooInTextBox()
        {
            if (listZoos.SelectedValue == null) return;

            try
            {
                string query = "select location from Zoo where Id = @ZooId";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                using (sqlDataAdapter)
                {
                    sqlCommand.Parameters.AddWithValue("@ZooId", listZoos.SelectedValue);
                    DataTable zooDataTable = new DataTable();
                    sqlDataAdapter.Fill(zooDataTable);

                    tb.Text = zooDataTable.Rows[0]["Location"].ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Test");
            }
        }

        private void ShowSelectedAnimalInTextBox()
        {
            if (listAnimals.SelectedValue == null) return;

            try
            {
                string query = "select name from Animal where Id = @AnimalId";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                using (sqlDataAdapter)
                {
                    sqlCommand.Parameters.AddWithValue("@AnimalId", listAnimals.SelectedValue);
                    DataTable animalDataTable = new DataTable();
                    sqlDataAdapter.Fill(animalDataTable);

                    tb.Text = animalDataTable.Rows[0]["Name"].ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Test");
            }
        }

        private void DeleteZoo_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string query = "delete from Zoo where id = @ZooId";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@ZooId", listZoos.SelectedValue);
                sqlCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlConnection.Close();
                ShowZoos();
            }
        }

        private void AddZoo_Click (object sender, RoutedEventArgs e)
        {
            try
            {
                string query = "insert into Zoo values (@Location)";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@Location", tb.Text);
                sqlCommand.ExecuteScalar();
            }
            catch (Exception)
            {
                MessageBox.Show("Fehler beim Hinzufügen eines Tieres zu einem Zoo.");
            }
            finally
            {
                sqlConnection.Close();
                ShowPresentAnimals();
            }
        }

        private void AddAnimal_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string query = "insert into Animal values (@Name)";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@Name", tb.Text);
                sqlCommand.ExecuteScalar();
            }
            catch (Exception)
            {
                MessageBox.Show("Fehler beim Hinzufügen eines Tieres.");
            }
            finally
            {
                sqlConnection.Close();
                ShowAnimals();
            }
        }

        private void DeleteAnimal_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string query = "delete from Animal where id = @AnimalId";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@AnimalId", listAnimals.SelectedValue);
                sqlCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                ShowAnimals();
                ShowPresentAnimals();
                sqlConnection.Close();
            }
        }

        private void AddAnimalToZoo_Click(object sender, RoutedEventArgs e)
        {
            if (listZoos.SelectedValue == null || listAnimals.SelectedValue == null)
            {
                return;
            }
            try
            {
                string query = "insert into ZooAnimal values (@ZooId, @AnimalId)";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@ZooId", listZoos.SelectedValue);
                sqlCommand.Parameters.AddWithValue("@AnimalId", listAnimals.SelectedValue);
                sqlCommand.ExecuteScalar();
            }
            catch (Exception)
            {
                MessageBox.Show("Fehler beim hinzufügen");
            }
            finally
            {
                ShowPresentAnimals();
                sqlConnection.Close();
            }
        }

        private void DeleteAnimalfromZoo_Click(object sender, RoutedEventArgs e)
        {
            if (listZoos.SelectedValue == null || listPresentAnimals.SelectedValue == null)
            {
                return;
            }
            try
            {
                string query = "delete from ZooAnimal where ZooId = @ZooId and AnimalId = @AnimalId";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@ZooId", listZoos.SelectedValue);
                sqlCommand.Parameters.AddWithValue("@AnimalId", listPresentAnimals.SelectedValue);
                sqlCommand.ExecuteScalar();
            }
            catch (Exception)
            {
                MessageBox.Show("Tier konnte nicht aus dem Zoo entfernt werden.");
            }
            finally
            {
                sqlConnection.Close();
                ShowPresentAnimals();
            }
        }

        private void UpdateZoo_Click(object sender, RoutedEventArgs e)
        {
            if (listZoos.SelectedValue == null ) return;
            
            try
            {
                string query = "update Zoo set Location = @Location where Id = @ZooId";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@ZooId", listZoos.SelectedValue);
                sqlCommand.Parameters.AddWithValue("@Location", tb.Text);
                sqlCommand.ExecuteScalar();
            }
            catch (Exception)
            {
                MessageBox.Show("Fehler beim Aktualisieren eines Zoos");
            }
            finally
            {
                ShowZoos();
                sqlConnection.Close();
            }
        }

        private void UpdateAnimal_Click(object sender, RoutedEventArgs e)
        {
            if (listAnimals.SelectedValue == null)
            {
                return;
            }
            try
            {
                string query = "update Animal set Name = @Name where Id = @AnimalId";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@Name", tb.Text);
                sqlCommand.Parameters.AddWithValue("@AnimalId", listAnimals.SelectedValue);
                sqlCommand.ExecuteScalar();
            }
            catch (Exception)
            {
                MessageBox.Show("Fehler beim Aktualiseiren eines Tiers");
            }
            finally
            {
                ShowAnimals();
                sqlConnection.Close();
            }
        }
    }
}
