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
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace Memory
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        


        public MainWindow()
        {
            InitializeComponent();

            
            //dodavanje slika u kvadrate
            //var brush = new ImageBrush();
            //try
            //{
            //    brush.ImageSource = new BitmapImage(new Uri("pack://siteoforigin:,,,/Slike/DSC_1083.jpg"));
            //}
            //catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            //b.Background = brush;
        }

        private void button_pokreni_Click(object sender, RoutedEventArgs e)
        {
            Igra igra = new Igra();
            igra.Show();
            this.Close();
        }

        private void button_izadji_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void button_Graf_Click(object sender, RoutedEventArgs e)
        {
            Krug k = new Krug();
            grid2.Children.Add(k);
            
         
        }
    }
}
