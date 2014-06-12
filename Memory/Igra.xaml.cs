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
using System.Windows.Threading;

namespace Memory
{
    /// <summary>
    /// Interaction logic for Igra.xaml
    /// </summary>
    public partial class Igra : Window
    {
        public int brojac_poteza;
        Slike s = new Slike();
        Button b;
        public Kvadrat k1; 
        public Kvadrat k2;
        public int pogodjeni = 0;

        public Igra()
        {
            InitializeComponent();
        }

        //TIMER
        public int i = 0, j = 0;
        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            i++;
            if (i > 59)
            {
                j++;
                i = 0;
            }
            else label_time.Content = j + ":" + i;
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            List<Kvadrat> kvadrati = new List<Kvadrat>();
            //random niz brojeva od 0 do 19
            System.Random rnd = new System.Random();
            var random_indeksi = Enumerable.Range(0, 20).OrderBy(r => rnd.Next()).ToArray();

            //dodavanje user controla na panel sa random slikama
            
            for (int i = 0; i < 20; i++)
            {
                kvadrati.Add(new Kvadrat(s.slike[random_indeksi[i]], this));
            }
            
            foreach (Kvadrat k in kvadrati)
            {
                k.Height = 52;
                k.Width = 50;
                wrapPanel.Children.Add(k);
                k.image1.Stretch = Stretch.Fill;
                b = k.dajButton();
                b.Background = Brushes.Black;            }

            wrapPanel.Visibility = System.Windows.Visibility.Hidden;
        }        

        private void button_zapocni_Click1(object sender, RoutedEventArgs e)
        {

            if (texbox_nick.Text.Length == 0)
            {
                MessageBox.Show("Unesite ime");
            }
            else
            {
                wrapPanel.Visibility = System.Windows.Visibility.Visible;

                DispatcherTimer dispatcherTimer = new DispatcherTimer();
                dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
                dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
                dispatcherTimer.Start();

                Igrac c = new Igrac(texbox_nick.Text, 5, 0);

            }
        }
    }
}
