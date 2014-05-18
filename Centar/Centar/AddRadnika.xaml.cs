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

namespace edit_i_dodavanje_radnika
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

        private void textBox_opisPosla_add_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (textBox_opisPosla_add.Text.ToLower() == "admin")
            {
                label_password_add.Visibility = System.Windows.Visibility.Visible;
                label_username_add.Visibility = System.Windows.Visibility.Visible;
                textBox_username_add.Visibility = System.Windows.Visibility.Visible;
                pwBox_add.Visibility = System.Windows.Visibility.Visible;
            }
            else
            {
                label_password_add.Visibility = System.Windows.Visibility.Hidden;
                label_username_add.Visibility = System.Windows.Visibility.Hidden;
                textBox_username_add.Visibility = System.Windows.Visibility.Hidden;
                pwBox_add.Visibility = System.Windows.Visibility.Hidden;
            }
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            label_password_add.Visibility = System.Windows.Visibility.Hidden;
            label_username_add.Visibility = System.Windows.Visibility.Hidden;
            textBox_username_add.Visibility = System.Windows.Visibility.Hidden;
            pwBox_add.Visibility = System.Windows.Visibility.Hidden;
        }
    }
}
