using System;
using System.Collections.Generic;
using System.IO;
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

namespace Memory
{
    /// <summary>
    /// Interaction logic for Kvadrat.xaml
    /// </summary>
    public partial class Kvadrat : UserControl
    {        
        private Igra igra;

        public Kvadrat()
        {
            InitializeComponent();
        }        

        public Kvadrat(Image image, Igra igra)
        {
            InitializeComponent();

            image1.Visibility = System.Windows.Visibility.Hidden;

            image1.Source = image.Source;
            this.igra = igra;
        }

        public void button1_Click(object sender, RoutedEventArgs e)
        {
            if (igra.brojac_poteza == 2)
            {
                if (igra.k1.image1.Source.ToString() == igra.k2.image1.Source.ToString() && igra.k1.button1 != igra.k2.button1)
                {
                    igra.k1.image1.Visibility = System.Windows.Visibility.Visible;
                    igra.k2.image1.Visibility = System.Windows.Visibility.Visible;
                }
                else
                {
                    igra.k1.button1.Background = Brushes.Black;
                    igra.k1.button1.Background = Brushes.Black;
                    igra.k1.image1.Visibility = System.Windows.Visibility.Hidden;
                    igra.k2.image1.Visibility = System.Windows.Visibility.Hidden;
                }

                igra.brojac_poteza = 0;

            }
            else igra.brojac_poteza++;
            if (igra.brojac_poteza == 1)
            {
                igra.k1 = this;
                image1.Visibility = System.Windows.Visibility.Visible;
            }
            else if (igra.brojac_poteza == 2)
            {
                igra.k2 = this;
                image1.Visibility = System.Windows.Visibility.Visible;
                if (igra.k1.image1.Source.ToString() == igra.k2.image1.Source.ToString() && igra.k1.button1 != igra.k2.button1)
                {
                    igra.pogodjeni++;
                    igra.brojac_poteza = 0;

                    igra.k1.IsEnabled = false;

                    igra.k2.IsEnabled = false;
                    if (igra.pogodjeni == 10)
                    {
                        MessageBox.Show("Zavrsili ste igru vase vrijeme: " + igra.j + ":" + igra.i);
                        opcije o = new opcije();
                        o.Show();
                        igra.Close();
                    }
                }
            }
           
        }

        public Button dajButton()
        {
            return this.button1;
        }

        public Image dajSliku()
        {
            return this.image1;
        }

        public void sakrijSliku() { image1.Visibility = System.Windows.Visibility.Hidden; }
        //public EventHandler vratiEvent() { return button1_Click(this, UserControl); }
    }
}
