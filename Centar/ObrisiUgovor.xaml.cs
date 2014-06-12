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
    /// Interaction logic for ObrisiUgovor.xaml
    /// </summary>
    public partial class ObrisiUgovor : Window
    {
        public ObrisiUgovor()
        {
            InitializeComponent();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                listbox_ugovori.Items.Clear();
                UgovorDAO u = new UgovorDAO("localhost", "Centar", "root", "");
                List<Ugovor> ugovori = new List<Ugovor>();
                ugovori = u.getAll();

                if (ugovori == null)
                {
                    System.Windows.Forms.MessageBox.Show("Prazna lista ugovora, unesite ugovor");
                    this.Close();
                }
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

        private void button_cancel_Click(object sender, RoutedEventArgs e)
        {
            Ugovor_Opcije u = new Ugovor_Opcije();
            u.Show();
            this.Close();
        }

        private void button_obrisi1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //stavljanje psa na udomljavanje 

            }
            catch (Exception izuz)
            {
                System.Windows.Forms.MessageBox.Show(izuz.Message);
            }

        }
    }
}
