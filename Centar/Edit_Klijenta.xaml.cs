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

namespace Edit_Klijenta_namespace
{
    /// <summary>
    /// Interaction logic for Edit_Klijenta.xaml
    /// </summary>
    public partial class Edit_Klijenta : Window
    {
        Klijent klijent;
        public Edit_Klijenta()
        {
            InitializeComponent();
        }

        public Edit_Klijenta(Klijent k)
        {
            InitializeComponent();
            klijent = k;
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            //ucitavanje u combobox
            PasDAO p = new PasDAO("localhost", "Centar", "root", "");
            List<Pas> psi = new List<Pas>();
            psi = p.getAllUdomljeneINeudomljene();

            foreach (Pas kl in psi)
            {
                comboBox_vlasnikPsa.Items.Add(kl);
            }

            textBox_jmb_edit.Text = klijent.jmb;
            textBox_ime_edit.Text = klijent.ime;
            textBox_prezime_edit.Text = klijent.prezime;
            textBox_adresa_edit.Text = klijent.adresa;
            for (int i = 0; i < comboBox_vlasnikPsa.Items.Count; i++)
            {
                if ( ((Pas)comboBox_vlasnikPsa.Items[i]).id==klijent.vlasnikPsa.id)
                {
                    comboBox_vlasnikPsa.SelectedIndex = i;
                }
            }
            datePicker_datumPreuzimanja.SelectedDate = klijent.datumPreuzimanjaPsa;
        }

        private void button_cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void button_edit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                klijent = new Klijent(textBox_jmb_edit.Text, textBox_ime_edit.Text, textBox_prezime_edit.Text, textBox_adresa_edit.Text, (Pas)comboBox_vlasnikPsa.SelectedItem, datePicker_datumPreuzimanja.SelectedDate.Value);
                KlijentDAO k = new KlijentDAO("localhost", "Centar", "root", ""); ;
                k.update(klijent);

                PasDAO pasDao = new PasDAO("localhost", "Centar", "root", "");
                Pas pas = new Pas(((Pas)comboBox_vlasnikPsa.SelectedItem).id, ((Pas)comboBox_vlasnikPsa.SelectedItem).zdravstvenoStanje, "Udomljen", ((Pas)comboBox_vlasnikPsa.SelectedItem).datumRodjenja, ((Pas)comboBox_vlasnikPsa.SelectedItem).datumCipiranja, ((Pas)comboBox_vlasnikPsa.SelectedItem).sterilizovan, ((Pas)comboBox_vlasnikPsa.SelectedItem).datumSterilizacije);
                pasDao.update(pas);

                PasDAO pasDao2 = new PasDAO("localhost", "Centar", "root", "");
                Pas pasStari = new Pas(klijent.vlasnikPsa.id, klijent.vlasnikPsa.zdravstvenoStanje, "Ceka udomljavanje", klijent.vlasnikPsa.datumRodjenja , klijent.vlasnikPsa.datumCipiranja , klijent.vlasnikPsa.sterilizovan, klijent.vlasnikPsa.datumSterilizacije);
                pasDao2.update(pasStari);
                this.Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
