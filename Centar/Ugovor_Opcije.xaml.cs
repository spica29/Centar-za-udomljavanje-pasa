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
    /// Interaction logic for Ugovor_Opcije.xaml
    /// </summary>
    public partial class Ugovor_Opcije : Window
    {
        public Ugovor_Opcije()
        {
            InitializeComponent();
        }

        private void button_potpisiUgovor_Click(object sender, RoutedEventArgs e)
        {
            PotpisiUgovor p = new PotpisiUgovor();
            p.ShowDialog();
            this.Close();
        }

        private void button_obrisiUgovor_Click(object sender, RoutedEventArgs e)
        {
            /*
            ObrisiUgovor o = new ObrisiUgovor();
            o.ShowDialog();
            this.Close();*/
            try
            {
                PasDAO p = new PasDAO("localhost", "Centar", "root", "");
                List<Pas> pas = p.getByExample(((Ugovor)listbox_ugovori.SelectedItem).Pas.id.ToString());
                pas[0].status = "Ceka udomljavanje";
                PasDAO p1 = new PasDAO("localhost", "Centar", "root", "");
                p1.update(pas[0]);

                UgovorDAO u = new UgovorDAO("localhost", "Centar", "root", "");
                Ugovor ugovor = ((Ugovor)listbox_ugovori.SelectedItem);
                u.delete(ugovor);



                Grid_Loaded_1(sender, e);

            }
            catch (Exception izuz)
            {
                System.Windows.Forms.MessageBox.Show(izuz.Message);
            }
        }

        private void button_ispisiUgovore_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                listbox_ugovori.Items.Clear();
                UgovorDAO u = new UgovorDAO("localhost", "Centar", "root", "");
                List<Ugovor> ugovori = new List<Ugovor>();
                ugovori=u.getAll();
                foreach (Ugovor u1 in ugovori)
                {
                    listbox_ugovori.Items.Add(u1);
                }            
            }
            catch (Exception izuz)
            {
                System.Windows.Forms.MessageBox.Show(izuz.Message);
            }

        }

        private void Grid_Loaded_1(object sender, RoutedEventArgs e)
        {
            try
            {
                listbox_ugovori.Items.Clear();
                UgovorDAO u = new UgovorDAO("localhost", "Centar", "root", "");
                List<Ugovor> ugovori = new List<Ugovor>();
                ugovori = u.getAll();

                foreach (Ugovor u1 in ugovori)
                {
                    listbox_ugovori.Items.Add(u1);
                }
            }
            catch (Exception izuz)
            {
                System.Windows.Forms.MessageBox.Show(izuz.Message);
            }
            
        }
    }
}
