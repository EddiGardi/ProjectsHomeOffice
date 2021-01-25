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

namespace Essensverwaltung
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Person> persons = JsonConvert.DeserializeObject<List<Person>>(File.ReadAllText(@"C:\Users\Edgard Frank\source\repos\Essensverwaltung\Datenbank_Persons.json"));
        List<Article> articles = JsonConvert.DeserializeObject<List<Article>>(File.ReadAllText(@"C:\Users\Edgard Frank\source\repos\Essensverwaltung\Datenbank_Articles.json"));

        bool wahr = false;

        public MainWindow()
        {
            InitializeComponent();
            dg_Persons.ItemsSource = persons;
            dg_Articles.ItemsSource = articles;
        }

        private void BuyStuff_Click(object sender, RoutedEventArgs e)
        {
            buyPopUp.IsOpen = true;
        }

        private void AddArticle_Click(object sender, RoutedEventArgs e)
        {
            articlePopUp.IsOpen = true;
        }

        private void AddPerson_Click(object sender, RoutedEventArgs e)
        {
            personPopUp.IsOpen = true;
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            File.Delete(@"C:\Users\Edgard Frank\source\repos\Essensverwaltung\Datenbank_Persons.json");
            File.Delete(@"C:\Users\Edgard Frank\source\repos\Essensverwaltung\Datenbank_Articles.json");

            using (StreamWriter file = File.CreateText(@"C:\Users\Edgard Frank\source\repos\Essensverwaltung\Datenbank_Persons.json"))
            {
                JsonSerializer serializer = new JsonSerializer();

                serializer.Serialize(file, persons);

            }
            using (StreamWriter file = File.CreateText(@"C:\Users\Edgard Frank\source\repos\Essensverwaltung\Datenbank_Articles.json"))
            {
                JsonSerializer serializer = new JsonSerializer();

                serializer.Serialize(file, articles);
            }
            MessageBox.Show("Datei gespeichert.");
        }

        private void AddNewArticle_Click (object sender, RoutedEventArgs e)
        {
            CheckCorrectInput("Article","New");
            if (wahr)
            {
                var article = new Article(tbname.Text, Convert.ToDecimal(tbprice.Text.Replace(".", ",")), Convert.ToInt32(tbamount.Text));
                if (articles == null) articles = new List<Article> { article };
                else articles.Add(article);
                MessageBox.Show(article.ArticleName + " hinzugefügt.");
                ReloadDataGrid();
            }
            else MessageBox.Show("Fehlerhafte Eingabe. Bitte Wiederholen.");
        }

        private void ChangePriceArticle_Click (object sender, RoutedEventArgs e)
        {
            CheckCorrectInput("Article","Price");
            int i = 0;

            if (articles != null)
            {
                if (wahr)
                {
                    while (articles[i].ArticleName != tbname.Text && i < articles.Count)
                    {
                        i++;
                    }
                    if (articles[i].ArticleName != tbname.Text)
                    {
                        MessageBox.Show("Element nicht vorhanden. Bitte neu anlegen.");
                    }
                    else articles[i].Price = Convert.ToDecimal(tbprice.Text.Replace(".", ","));
                }
                else MessageBox.Show("Fehlerhafte Eingabe. Bitte Wiederholen.");
            }
            else MessageBox.Show("Artikelliste ist noch leer.");
            ReloadDataGrid();
        }

        private void ChangeAmountArticle_Click (object sender, RoutedEventArgs e)
        {
            CheckCorrectInput("Article","Amount");
            int i = 0;
            if (articles != null)
            {
                if (wahr)
                {
                    while (articles[i].ArticleName != tbname.Text && i < articles.Count)
                    {
                        i++;
                    }
                    if (articles[i].ArticleName != tbname.Text)
                    {
                        MessageBox.Show("Element nicht vorhanden. Bitte neu anlegen.");
                    }
                    else articles[i].Amount = Convert.ToInt32(tbamount.Text);
                }
                else MessageBox.Show("Fehlerhafte Eingabe. Bitte Wiederholen.");
            }
            else MessageBox.Show("Artikelliste ist noch leer.");
            ReloadDataGrid();
        }

        private void DeleteArticle_Click (object sender, RoutedEventArgs e)
        {
            int i = 0;
            if (articles != null)
            {
                while (articles[i].ArticleName != tbname.Text && i < articles.Count)
                {
                    i++;
                }
                if (articles[i].ArticleName != tbname.Text)
                {
                    MessageBox.Show("Element nicht vorhanden.");
                }
                else
                {
                    MessageBox.Show(articles[i].ArticleName + " gelöscht.");
                    articles.Remove(articles[i]);
                }         
            }
            else MessageBox.Show("Artikelliste ist noch leer.");
            ReloadDataGrid();
        }

        private void AddNewPerson_Click (object sender, RoutedEventArgs e)
        {
            CheckCorrectInput("Person","New");
            if (wahr)
            {
                var person = new Person(tbPersonName.Text, tbPersonFirstName.Text, Convert.ToDecimal(tbPersonCredit.Text.Replace(".", ",")));
                if (persons == null) persons = new List<Person> { person };
                else persons.Add(person);
                MessageBox.Show(person.FirstName + " " + person.Name + " hinzugefügt.");
                ReloadDataGrid();
            }
            else MessageBox.Show("Fehlerhafte Eingabe. Bitte Wiederholen.");
        }

        private void ChangeCredit_Click(object sender, RoutedEventArgs e)
        {
            int i = 0;
            if (persons != null)
            {
                CheckCorrectInput("Person","Credit");
                if (wahr)
                {
                    while (persons[i].Name != tbPersonName.Text && i < persons.Count)
                    {
                        i++;
                    }
                    if (persons[i].Name != tbPersonName.Text)
                    {
                        MessageBox.Show("Element nicht vorhanden. Bitte neu anlegen.");
                    }
                    else persons[i].Credit = Convert.ToDecimal(tbPersonCredit.Text.Replace(".",","));
                }
                else MessageBox.Show("Fehlerhafte Eingabe. Bitte Wiederholen.");
            }
            else MessageBox.Show("Personenliste ist noch leer.");
            ReloadDataGrid();
        }

        private void DeletePerson_Click(object sender, RoutedEventArgs e)
        {
            int i = 0;
            if (persons != null)
            {
                while (persons[i].Name != tbPersonName.Text && i < persons.Count)
                {
                    i++;
                }
                if (persons[i].Name != tbPersonName.Text)
                {
                    MessageBox.Show("Element nicht vorhanden.");
                }
                else
                {
                    persons.Remove(persons[i]);
                    MessageBox.Show("Du hast " + tbPersonFirstName.Text + " " + tbPersonName.Text + " entfernt.");
                }
            }
            else MessageBox.Show("Personenliste ist noch leer.");
            ReloadDataGrid();
        }

        private void Buy_Click (object sender, RoutedEventArgs e)
        {
            int i = 0;
            int j = 0;

            if (persons != null && articles != null)
            {
                while (persons[i].Name != tbBuyPersName.Text && persons[i].FirstName != tbBuyPersFirstName.Text && i < persons.Count)
                {
                    i++;
                }
                if (persons[i].Name != tbBuyPersName.Text && persons[i].FirstName != tbBuyPersFirstName.Text)
                {
                    MessageBox.Show("Element nicht vorhanden. Bitte neu anlegen.");
                }
                else
                {
                    while (articles[j].ArticleName != tbBuyNameArticle.Text && j < articles.Count)
                    {
                        j++;
                    }
                    if (articles[j].ArticleName != tbBuyNameArticle.Text)
                    {
                        MessageBox.Show("Element nicht vorhanden. Bitte neu anlegen.");
                    }
                    else
                    {
                        CheckCorrectInput("Buy","Buy");
                        if (wahr)
                        {
                            if (articles[j].Amount - Convert.ToInt32(tbBuyAmount.Text) >= 0 && persons[i].Credit - articles[j].Price * Convert.ToInt32(tbBuyAmount.Text) >= 0)
                            {
                                articles[j].Amount -= Convert.ToInt32(tbBuyAmount.Text);
                                persons[i].Credit -= articles[j].Price * Convert.ToInt32(tbBuyAmount.Text);
                                MessageBox.Show(tbBuyPersFirstName + " " + tbBuyPersName + " hat " + Convert.ToInt32(tbBuyAmount.Text) + " mal " + tbBuyNameArticle + " gekauft.");
                                ReloadDataGrid();
                            }
                            else MessageBox.Show("Es sind nicht so viele Artikel vorhanden, wie man kaufen wollte oder das Guthaben reicht nicht.");
                        }
                        else MessageBox.Show("Fehlerhafte Eingabe. Bitte Wiederholen.");
                    }
                }
            }
            else
            {
                if (persons == null && articles != null) MessageBox.Show("Es sind keine Personen vorhanden.");
                if (persons != null && articles == null) MessageBox.Show("Es sind keine Artikel vorhanden.");
                else MessageBox.Show("Es sind weder Personen noch Artikel vorhanden.");
            }
        }

        private void ReloadDataGrid ()
        {
            dg_Articles.ItemsSource = null;
            dg_Articles.ItemsSource = articles;
            dg_Persons.ItemsSource = null;
            dg_Persons.ItemsSource = persons;
        }

        private void CheckCorrectInput (string sender, string group)
        {
            if (sender == "Article")
            {
                decimal helpDeci = 0;
                int helpInt = 0;
                if (group == "New")
                {
                    if (Decimal.TryParse(tbprice.Text, out helpDeci) && Int32.TryParse(tbamount.Text, out helpInt)) wahr = true;
                    else wahr = false;
                }
                else if (group == "Amount")
                {
                    if (Int32.TryParse(tbamount.Text, out helpInt)) wahr = true;
                    else wahr = false;
                }
                else
                {
                    if (Decimal.TryParse(tbprice.Text, out helpDeci)) wahr = true;
                    else wahr = false;
                }
            }
            else if (sender == "Person")
            {
                decimal helpDeci = 0;

                if (Decimal.TryParse(tbPersonCredit.Text, out helpDeci)) wahr = true;
                else wahr = false;
            }
            else
            {
                int helpInt = 0;
                if (Int32.TryParse(tbBuyAmount.Text, out helpInt)) wahr = true;
                else wahr = false;
            }
        }


    }
}
