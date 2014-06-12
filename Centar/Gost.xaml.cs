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
    /// Interaction logic for Gost.xaml
    /// </summary>
    public partial class Gost : Window
    {
        public Gost()
        {
            InitializeComponent();
        }

        private void button_sviAAA_Click(object sender, RoutedEventArgs e)
        {
            textbox_search.Visibility = System.Windows.Visibility.Hidden;
            listbox_psi.Items.Clear();
            PasDAO pd = new PasDAO("localhost", "Centar", "root", "");
            List<Pas> psi = new List<Pas>();
            psi = pd.getAll();
            foreach (Pas p in psi)
            {
                listbox_psi.Items.Add(p);
            }
        }

        private void button_id_Click(object sender, RoutedEventArgs e)
        {
            textbox_search.Visibility = System.Windows.Visibility.Visible;
        }

        private void button_pocetna_Click(object sender, RoutedEventArgs e)
        {
            MainWindow m = new MainWindow();
            m.Show();
            this.Close();

        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            textbox_search.Visibility = System.Windows.Visibility.Hidden;
        }

        private void textbox_search_TextChanged(object sender, TextChangedEventArgs e)
        {
            listbox_psi.Items.Clear();
            PasDAO pd = new PasDAO("localhost", "Centar", "root", "");
            List<Pas> psi = new List<Pas>();
            psi = pd.getAll();
            foreach (Pas p in psi)
            {
                if (p.id.ToString().Contains(textbox_search.Text))
                    listbox_psi.Items.Add(p);
            }
        }
    }
}
