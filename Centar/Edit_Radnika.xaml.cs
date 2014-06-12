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
using Centar;

namespace edit_i_dodavanje_radnika
{
    /// <summary>
    /// Interaction logic for edit.xaml
    /// </summary>
    public partial class Edit_Radnika : Window
    {
        private Radnik rad;

        public Edit_Radnika()
        {
            InitializeComponent();
        }

        public Edit_Radnika(Radnik r)
        {
            InitializeComponent();
            rad = r;
        }

        private void textBox_opisPosla_add_TextChanged(object sender, TextChangedEventArgs e)
        {
            string pom= textBox_username_edit.Text.ToLower();

            if (pom.Contains("admin"))
            {
                label_password_edit.Visibility = System.Windows.Visibility.Visible;
                label_username_edit.Visibility = System.Windows.Visibility.Visible;
                textBox_username_edit.Visibility = System.Windows.Visibility.Visible;
                pwBox_edit.Visibility = System.Windows.Visibility.Visible;
            }
            else
            {
                label_password_edit.Visibility = System.Windows.Visibility.Hidden;
                label_username_edit.Visibility = System.Windows.Visibility.Hidden;
                textBox_username_edit.Visibility = System.Windows.Visibility.Hidden;
                pwBox_edit.Visibility = System.Windows.Visibility.Hidden;
            }
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            label_password_edit.Visibility = System.Windows.Visibility.Hidden;
            label_username_edit.Visibility = System.Windows.Visibility.Hidden;
            textBox_username_edit.Visibility = System.Windows.Visibility.Hidden;
            pwBox_edit.Visibility = System.Windows.Visibility.Hidden;
            textBox_jmb_edit.IsEnabled = false;
        }

        private void button_edit_Click(object sender, RoutedEventArgs e)
        {
            Radnik pom;
            //update radnika na osnovu jmb
            try
            {
                if (textBox_username_edit.Text.Length == 0)
                {
                    textBox_username_edit.Text = null;
                    pwBox_edit.Password = null;
                }
                Radnik r = new Radnik(textBox_opisPosla_edit.Text, DatePicker_datumRodjenja_edit.SelectedDate.Value, textBox_jmb_edit.Text, textBox_ime_edit.Text, textBox_prezime_edit.Text, textBox_adresa_edit.Text, textBox_username_edit.Text, pwBox_edit.Password);
                RadnikDAO radnik = new RadnikDAO("localhost", "Centar", "root", ""); 
                pom = radnik.update(r);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_cancel_edit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Grid_Loaded_1(object sender, RoutedEventArgs e)
        {
            textBox_adresa_edit.Text = rad.adresa;
            textBox_ime_edit.Text = rad.ime;
            textBox_jmb_edit.Text = rad.jmb;
            textBox_opisPosla_edit.Text = rad.opisPosla;
            textBox_prezime_edit.Text = rad.prezime;
            textBox_username_edit.Text = rad.username;
            DatePicker_datumRodjenja_edit.SelectedDate = rad.datumRodjenja;
            pwBox_edit.Password = rad.password;
            if (textBox_opisPosla_edit.Text.Contains("admin"))
            {
                label_password_edit.Visibility = System.Windows.Visibility.Visible;
                label_username_edit.Visibility = System.Windows.Visibility.Visible;
                textBox_username_edit.Visibility = System.Windows.Visibility.Visible;
                pwBox_edit.Visibility = System.Windows.Visibility.Visible;
            }
        }
    }
}
