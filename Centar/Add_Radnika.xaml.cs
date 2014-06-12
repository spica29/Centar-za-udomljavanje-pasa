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
    /// Interaction logic for Add_Radnika.xaml
    /// </summary>
    public partial class Add_Radnika : Window
    {
        public Add_Radnika()
        {
            InitializeComponent();
        }

        private void textBox_opisPosla_add_TextChanged(object sender, TextChangedEventArgs e)
        {
            string pom;
            pom=textBox_opisPosla_add.Text.ToLower();
            if (pom.Contains("admin"))
            {
                label_password_add.Visibility = System.Windows.Visibility.Visible;
                label_username_add.Visibility = System.Windows.Visibility.Visible;
                textBox_username_add.Visibility = System.Windows.Visibility.Visible;
                pwBox_add.Visibility = System.Windows.Visibility.Visible;
            }
            else
            {
                label_password_add.Visibility = System.Windows.Visibility.Hidden;
                label_username_add.Visibility = System.Windows.Visibility.Hidden;
                textBox_username_add.Visibility = System.Windows.Visibility.Hidden;
                pwBox_add.Visibility = System.Windows.Visibility.Hidden;
            }
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            label_password_add.Visibility = System.Windows.Visibility.Hidden;
            label_username_add.Visibility = System.Windows.Visibility.Hidden;
            textBox_username_add.Visibility = System.Windows.Visibility.Hidden;
            pwBox_add.Visibility = System.Windows.Visibility.Hidden;
        }

        private void button_add_Click(object sender, RoutedEventArgs e)
        {
            //dodavanje radnika bruteforce
            try
            {
                if (textBox_username_add.Text.Length==0)
                {
                    textBox_username_add.Text = null;
                    pwBox_add.Password = null;
                }
                Radnik r = new Radnik(textBox_opisPosla_add.Text, DatePicker_datumRodjenja_add.SelectedDate.Value, textBox_jmb_add.Text, textBox_ime_add.Text, textBox_prezime_add.Text, textBox_adresa_add.Text, textBox_username_add.Text, pwBox_add.Password);
                RadnikDAO radnik = new RadnikDAO("localhost", "Centar", "root", "");
                radnik.create(r);
                System.Windows.Forms.MessageBox.Show("Radnik je uspiješno dodan","Obaviještenje");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_cancel_add_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
