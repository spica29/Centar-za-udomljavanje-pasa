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
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void bLogin_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                RadnikDAO radnikSpajanje = new RadnikDAO("localhost", "Centar", "root", "");
                List<Radnik> r = new List<Radnik>();
                r=radnikSpajanje.getByExample(tbUsername.Text, pbPassword.Password);
                if (r.Count!=0)
                {
                    System.Windows.Forms.MessageBox.Show("Dobro došao "+r[0].ime);
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Trazeni korisnik ne postoji");
                }

                //otvaranje nove forme i zatvaranje ove
                
                Login_prva lp = new Login_prva(r[0]); // TREBA PROSLIJEDITI PRONADJENOG RADNIKA FORMI !!!
                lp.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                
            }
            
        }

        private void Grid_Loaded_1(object sender, RoutedEventArgs e)
        {
            tbUsername.Focus();
        }
      
    }
}
