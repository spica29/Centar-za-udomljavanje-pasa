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
using edit_i_dodavanje_radnika;
using System.Windows.Forms;
using Add_psa_namespace;

namespace Centar
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void bLogIn_Click(object sender, RoutedEventArgs e)
        {
            Login loginForma = new Login();
            loginForma.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Add_Radnika dodajRadnika = new Add_Radnika();
            dodajRadnika.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Edit_Radnika editRadnika = new Edit_Radnika();
            editRadnika.Show();
        }

        private void button_login_Click(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void button_gost_Click(object sender, RoutedEventArgs e)
        {
            Gost g = new Gost();
            g.Show();
            this.Close();
        }

   
    
    }
}
