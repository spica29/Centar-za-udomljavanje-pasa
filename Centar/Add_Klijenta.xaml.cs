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

namespace Add_Klijenta_namespace
{
    /// <summary>
    /// Interaction logic for Add_Klijenta.xaml
    /// </summary>
    public partial class Add_Klijenta : Window
    {
        public Add_Klijenta()
        {
            InitializeComponent();
        }

        private void button_add_Click(object sender, RoutedEventArgs e)
        {
            Klijent k = new Klijent(textBox_jmb_edit.Text, textBox_ime_edit.Text, textBox_prezime_edit.Text, textBox_adresa_edit.Text, (Pas)comboBox_vlasnikPsa.SelectedItem, datePicker_datumPreuzimanja.SelectedDate.Value);
            KlijentDAO kl = new KlijentDAO("localhost", "Centar", "root", "");
            kl.create(k);

            PasDAO pasDao = new PasDAO("localhost", "Centar", "root", "");
            Pas pas = new Pas(((Pas)comboBox_vlasnikPsa.SelectedItem).id, ((Pas)comboBox_vlasnikPsa.SelectedItem).zdravstvenoStanje, "Udomljen", ((Pas)comboBox_vlasnikPsa.SelectedItem).datumRodjenja, ((Pas)comboBox_vlasnikPsa.SelectedItem).datumCipiranja, ((Pas)comboBox_vlasnikPsa.SelectedItem).sterilizovan, ((Pas)comboBox_vlasnikPsa.SelectedItem).datumSterilizacije);
            pasDao.update(pas);
            this.Close();
        }

        private void button_cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Grid_Loaded_1(object sender, RoutedEventArgs e)
        {
            //ucitavanje u combobox
            PasDAO p = new PasDAO("localhost", "Centar", "root", "");
            List<Pas> psi = new List<Pas>();
            psi = p.getAllNeudomljene();

            if (psi == null)
            {
                System.Windows.Forms.MessageBox.Show("Nema pasa spremnih za udomljavanje");
                this.Close();
            }

            foreach (Pas kl in psi)
            {
                comboBox_vlasnikPsa.Items.Add(kl);
            }
        }
    }
}
