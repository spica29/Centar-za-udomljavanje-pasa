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

namespace Memory
{
    /// <summary>
    /// Interaction logic for opcije.xaml
    /// </summary>
    public partial class opcije : Window
    {
        public opcije()
        {
            InitializeComponent();
        }

        private void button_pocetna_Click(object sender, RoutedEventArgs e)
        {
            MainWindow m = new MainWindow();
            m.Show();
            this.Close();
        }

        private void button_ponovo_Click(object sender, RoutedEventArgs e)
        {
            Igra i = new Igra();
            i.Show();
            this.Close();
        }

        private void button_izadji_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
