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

namespace Edit_psa_namespace
{
    /// <summary>
    /// Interaction logic for Edit_Psa.xaml
    /// </summary>
    public partial class Edit_Psa : Window
    {
        Pas pas;
        public Edit_Psa()
        {
            InitializeComponent();
        }

        public Edit_Psa(Pas p)
        {
            InitializeComponent();
            pas = p;
        }

        private void radioButton_da_add_Checked(object sender, RoutedEventArgs e)
        {
            datePicker_datSter_add.Visibility = System.Windows.Visibility.Visible;
            label_datumSterilizacije_add.Visibility = System.Windows.Visibility.Visible;
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            //postavljanje datuma sterilizacije na invisible dok se ne obiljezi da je pas sterilizovan
            label_datumSterilizacije_add.Visibility = System.Windows.Visibility.Hidden;
            datePicker_datSter_add.Visibility = System.Windows.Visibility.Hidden;

            //zdravstveno stanje ComboBox
            ComboBox_zdrStanje_add.Items.Clear();
            ComboBox_zdrStanje_add.Items.Add("Zdrav");
            ComboBox_zdrStanje_add.Items.Add("Bolestan");
            ComboBox_zdrStanje_add.Items.Add("Nesocijalizovan");

            //status ComboBox
            comboBox_status_add.Items.Clear();
            comboBox_status_add.Items.Add("Ceka udomljavanje");
            comboBox_status_add.Items.Add("Udomljen");
            comboBox_status_add.Items.Add("Nesposoban za udomljavanje");

            textBox_idPsa_add.IsEnabled = false;

            //ucitavanje vlasnika iz baze u ComboBox
        }

        private void buttonCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void radioButton_ne_add_Checked(object sender, RoutedEventArgs e)
        {
            datePicker_datSter_add.Visibility = System.Windows.Visibility.Hidden;
            label_datumSterilizacije_add.Visibility = System.Windows.Visibility.Hidden;
        }

        private void buttonEdit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                pas = new Pas(Convert.ToInt32(textBox_idPsa_add.Text), ComboBox_zdrStanje_add.SelectedItem.ToString(), comboBox_status_add.SelectedItem.ToString());
                if (radioButton_da_add.IsChecked == true)
                {
                    pas.sterilizovan = true;
                    pas.datumSterilizacije = datePicker_datSter_add.SelectedDate.Value;
                }
                else pas.sterilizovan = false;

                if (datePicker_datCipiranja_add.SelectedDate != null)
                {
                    pas.datumCipiranja = datePicker_datCipiranja_add.SelectedDate.Value;
                }

                if (datePicker_datRodj_add.SelectedDate != null)
                {
                    pas.datumRodjenja = datePicker_datRodj_add.SelectedDate.Value;
                }

                /*if (pas.status.ToLower() == "udomljen")
                {
                     pas.vlasnik = (Klijent)comboBox_vlasnik_add.SelectedItem;
                }*/
                PasDAO pasDao = new PasDAO("localhost", "Centar", "root", "");
                pasDao.update(pas);
                this.Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message.ToString());
            }
        }

        private void Grid_Loaded_1(object sender, RoutedEventArgs e)
        {
            textBox_idPsa_add.Text = pas.id.ToString();
            ComboBox_zdrStanje_add.SelectedItem = pas.zdravstvenoStanje;
            comboBox_status_add.SelectedItem = pas.status;
            datePicker_datCipiranja_add.SelectedDate = pas.datumCipiranja;
            datePicker_datRodj_add.SelectedDate = pas.datumRodjenja;
            datePicker_datSter_add.SelectedDate = pas.datumSterilizacije;
            if (pas.sterilizovan)
            {
                radioButton_da_add.IsChecked = true;
            }
            else 
            {
                radioButton_ne_add.IsChecked = true;
            }
        }

        private void buttonKamera_Click(object sender, RoutedEventArgs e)
        {
            WebCamera web = new WebCamera();
            web.ShowDialog();
        }
    }
}
