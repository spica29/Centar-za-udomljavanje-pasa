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
    /// Interaction logic for Krug.xaml
    /// </summary>
    public partial class Krug : UserControl
    {
        public Krug()
        {
            InitializeComponent();
        }

        private void Grid_Loaded_1(object sender, RoutedEventArgs e)
        {
            StackPanel myStackPanel = new StackPanel();

            Ellipse myEllipse = new Ellipse();

            SolidColorBrush mySolidColorBrush = new SolidColorBrush();


            mySolidColorBrush.Color = Color.FromArgb(255, 255, 255, 0);
            myEllipse.Fill = mySolidColorBrush;
            myEllipse.StrokeThickness = 2;
            myEllipse.Stroke = Brushes.Black;

            myEllipse.Width = 200;
            myEllipse.Height = 100;

            myStackPanel.Children.Add(myEllipse);

            this.Content = myStackPanel;
        }
    }
}
