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
using System.Windows.Shapes;

namespace Centar
{
    /// <summary>
    /// Interaction logic for Login_prva.xaml
    /// </summary>
    public partial class Login_prva : Window
    {
        Radnik r;
        bool ButtonSearch = false;
        bool ButtonUgovor = false;
        bool ButtonEvidencija = false;
        bool ButtonDodaj = false;

        public Login_prva()
        {
            InitializeComponent();
        }

        public Login_prva(Radnik rad)
        {
            InitializeComponent();
            r = rad;
        }


        private void button_logout_Click(object sender, RoutedEventArgs e)
        {
            MainWindow m = new MainWindow();
            this.Close();
            m.Show();
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            label_welcomeAdmin.Content += r.ime;
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            label_welcomeAdmin.Content += " " + r.ime;

            radioButton_searchPsa.IsChecked = true;

            radioButton_searchKlijenta.Visibility = System.Windows.Visibility.Hidden;
            radioButton_searchPsa.Visibility = System.Windows.Visibility.Hidden;
            radioButton_searchRadnika.Visibility = System.Windows.Visibility.Hidden;
            textBox_search.Visibility = System.Windows.Visibility.Hidden;
            listBox_login.Visibility = System.Windows.Visibility.Hidden;
        }

        private void textBox_search_TextChanged(object sender, TextChangedEventArgs e)
        {
            listBox_login.Items.Clear();
            if (textBox_search.Text.Length == 0)
            {
                ProvjeraIDOdavanjeUlistuSvega();
            }
            if (radioButton_searchPsa.IsChecked == true) // pretraga po psu
            {
                PasDAO pas1 = new PasDAO("localhost", "Centar", "root", "");
                List<Pas> p = new List<Pas>();
                p = pas1.getAll();
                listBox_login.Items.Clear();
                foreach (Pas pas in p)
                {
                    if(pas.id.ToString().Contains(textBox_search.Text))
                        listBox_login.Items.Add(pas);
                }
            }
            else if (radioButton_searchKlijenta.IsChecked == true) // pretraga po klijentu
            {
                KlijentDAO k1 = new KlijentDAO("localhost", "Centar", "root", "");
                List<Klijent> k = new List<Klijent>();
                k = k1.getAll();
                listBox_login.Items.Clear();
                foreach (Klijent k2 in k)
                {
                    if(k2.jmb.ToString().Contains(textBox_search.Text))
                        listBox_login.Items.Add(k2);
                }
            }
            else // pretraga po radnicima
            {
                RadnikDAO radnik1 = new RadnikDAO("localhost", "Centar", "root", "");
                List<Radnik> p = new List<Radnik>();
                p = radnik1.getAll();
                listBox_login.Items.Clear();
                foreach (Radnik r in p)
                {
                    if(r.jmb.ToString().Contains(textBox_search.Text))
                        listBox_login.Items.Add(r);
                    
                }
            }
        }


        private void MenuItemObrisi_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (radioButton_searchKlijenta.IsChecked == true)
                {
                    KlijentDAO k1 = new KlijentDAO("localhost", "Centar", "root", "");
                    Klijent k = new Klijent();
                    k = listBox_login.SelectedItem as Klijent;
                    k1.delete(k);

                }
                else if (radioButton_searchPsa.IsChecked == true)
                {
                    PasDAO pas1 = new PasDAO("localhost", "Centar", "root", "");
                    Pas p = new Pas();
                    p = listBox_login.SelectedItem as Pas;
                    pas1.delete(p);

                }
                else if (radioButton_searchRadnika.IsChecked == true)
                {
                    RadnikDAO radnik1 = new RadnikDAO("localhost", "Centar", "root", "");
                    Radnik r = new Radnik();
                    r = listBox_login.SelectedItem as Radnik;
                    radnik1.delete(r);
                }
                listBox_login.Items.Remove(listBox_login.SelectedItem);
            }
            catch (Exception izuz)
            {
                System.Windows.Forms.MessageBox.Show(izuz.Message);
            }
        }


        private void MenuItemEdit_Click(object sender, RoutedEventArgs e)
        {
            if (radioButton_searchKlijenta.IsChecked == true)
            {
                Klijent k = new Klijent();
                k = listBox_login.SelectedItem as Klijent;
                Edit_Klijenta_namespace.Edit_Klijenta editKlijenta = new Edit_Klijenta_namespace.Edit_Klijenta(k);
                editKlijenta.ShowDialog();
            }
            else if (radioButton_searchPsa.IsChecked == true)
            {
                Pas p=new Pas();
                p = listBox_login.SelectedItem as Pas;
                Edit_psa_namespace.Edit_Psa editPsa = new Edit_psa_namespace.Edit_Psa(p);
                editPsa.ShowDialog();
                
            }
            else if (radioButton_searchRadnika.IsChecked == true)
            {
                Radnik r = new Radnik();
                r = listBox_login.SelectedItem as Radnik;
                edit_i_dodavanje_radnika.Edit_Radnika EditovanjeRadnika = new edit_i_dodavanje_radnika.Edit_Radnika(r);
                EditovanjeRadnika.ShowDialog();
            }
        }

        private void button_search_Click(object sender, RoutedEventArgs e)
        {
            ButtonSearch = true; // pritisnut button za search
            ButtonEvidencija = false;
            ButtonUgovor = false;
            ButtonDodaj = false;

            button_Ugovor.Visibility = System.Windows.Visibility.Hidden;
            button_Dodavanje.Visibility = System.Windows.Visibility.Hidden;

            radioButton_searchKlijenta.Visibility = System.Windows.Visibility.Visible;
            radioButton_searchPsa.Visibility = System.Windows.Visibility.Visible;
            radioButton_searchRadnika.Visibility = System.Windows.Visibility.Visible;
            textBox_search.Visibility = System.Windows.Visibility.Visible;
            listBox_login.Visibility = System.Windows.Visibility.Visible;

            ProvjeraIDOdavanjeUlistuSvega();
            
        }

        private void button_dodavanje_click(object sender, RoutedEventArgs e)
        {
            ButtonSearch = false; // pritisnut button za dodavanje
            ButtonEvidencija = false;
            ButtonUgovor = false;
            ButtonDodaj = true;

            radioButton_searchKlijenta.Visibility = Visibility.Visible;
            radioButton_searchPsa.Visibility = Visibility.Visible;
            radioButton_searchRadnika.Visibility = Visibility.Visible;

            radioButton_searchKlijenta.IsChecked = false;
            radioButton_searchPsa.IsChecked = false;
            radioButton_searchRadnika.IsChecked = false;
        }

        private void button_vratimeni_Click(object sender, RoutedEventArgs e)
        {
            button_Dodavanje.Visibility = System.Windows.Visibility.Visible;
            button_search.Visibility = System.Windows.Visibility.Visible;
            button_Ugovor.Visibility = System.Windows.Visibility.Visible;

            radioButton_searchKlijenta.Visibility = System.Windows.Visibility.Hidden;
            radioButton_searchPsa.Visibility = System.Windows.Visibility.Hidden;
            radioButton_searchRadnika.Visibility = System.Windows.Visibility.Hidden;
            textBox_search.Visibility = System.Windows.Visibility.Hidden;
            listBox_login.Visibility = System.Windows.Visibility.Hidden;

            listBox_login.Items.Clear();
            textBox_search.Text = "";
        }

        private void button_evidencija_Click(object sender, RoutedEventArgs e)
        {
            ButtonSearch = false; // pritisnut button za editovanje
            ButtonEvidencija = true;
            ButtonUgovor = false;
            ButtonDodaj = false;

            button_Dodavanje.Visibility = System.Windows.Visibility.Hidden;
            button_search.Visibility = System.Windows.Visibility.Hidden;
            button_Ugovor.Visibility = System.Windows.Visibility.Hidden;

            radioButton_searchKlijenta.Visibility = System.Windows.Visibility.Visible;
            radioButton_searchPsa.Visibility = System.Windows.Visibility.Visible;
            radioButton_searchRadnika.Visibility = System.Windows.Visibility.Visible;
            textBox_search.Visibility = System.Windows.Visibility.Visible;
            listBox_login.Visibility = System.Windows.Visibility.Visible;
        }

        private void button_ugovor_Click(object sender, RoutedEventArgs e)
        {
            ButtonSearch = false; // pritisnut button za ugovor
            ButtonEvidencija = false;
            ButtonUgovor = true;
            ButtonDodaj = false;

            button_Dodavanje.Visibility = System.Windows.Visibility.Hidden;
            button_search.Visibility = System.Windows.Visibility.Hidden;

            radioButton_searchKlijenta.Visibility = System.Windows.Visibility.Hidden;
            radioButton_searchPsa.Visibility = System.Windows.Visibility.Hidden;
            radioButton_searchRadnika.Visibility = System.Windows.Visibility.Hidden;
            textBox_search.Visibility = System.Windows.Visibility.Hidden;
            listBox_login.Visibility = System.Windows.Visibility.Hidden;

            Ugovor_Opcije ugovor = new Ugovor_Opcije();
            ugovor.ShowDialog();
        }


        private void radioButton_searchKlijenta_Checked(object sender, RoutedEventArgs e)
        {
            try
            {
                ProvjeraIDOdavanjeUlistuSvega();
                ProvjeraDodavanjaIDodavanjeForme();
            }
            catch (Exception izuz)
            {
                System.Windows.Forms.MessageBox.Show(izuz.Message);
            }
        }

        private void ProvjeraDodavanjaIDodavanjeForme()
        {
            if (ButtonDodaj)
            {
                if (radioButton_searchPsa.IsChecked == true)
                {
                    //dodavanje psa
                    Add_psa_namespace.Add_Psa add = new Add_psa_namespace.Add_Psa();
                    add.ShowDialog();
                }
                else if (radioButton_searchRadnika.IsChecked == true)
                {
                    //dodavanje radnika
                    edit_i_dodavanje_radnika.Add_Radnika AddRadnik = new edit_i_dodavanje_radnika.Add_Radnika();
                    AddRadnik.ShowDialog();
                }
                else 
                {
                    //dodavanje klijenta
                    Add_Klijenta_namespace.Add_Klijenta add = new Add_Klijenta_namespace.Add_Klijenta();
                    add.ShowDialog();
                
                }
            }
        }

        private void ProvjeraIDOdavanjeUlistuSvega()
        {

            listBox_login.Items.Clear();
            if (ButtonSearch)
            {
                if (radioButton_searchKlijenta.IsChecked == true)
                {
                    KlijentDAO k1 = new KlijentDAO("localhost", "Centar", "root", "");
                    List<Klijent> k = new List<Klijent>();
                    k = k1.getAll();
                    foreach (Klijent kl in k)
                    {
                        listBox_login.Items.Add(kl);
                    }
                }
                else if (radioButton_searchPsa.IsChecked == true)
                {
                    PasDAO pas1 = new PasDAO("localhost", "Centar", "root", "");
                    List<Pas> p = new List<Pas>();
                    p = pas1.getAll();
                    foreach (Pas pas in p)
                    {
                        listBox_login.Items.Add(pas);
                    }

                }
                else if (radioButton_searchRadnika.IsChecked == true)
                {
                    RadnikDAO radnik1 = new RadnikDAO("localhost", "Centar", "root", "");
                    List<Radnik> p = new List<Radnik>();
                    p = radnik1.getAll();
                    foreach (Radnik r in p)
                    {
                        listBox_login.Items.Add(r);

                    }
                }
            }
        }
    }
}
