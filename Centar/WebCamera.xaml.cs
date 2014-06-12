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
using Microsoft.Expression.Encoder;
using WebcamControl;
using System.Drawing.Design;
using Microsoft.Expression.Encoder.Devices;
using OnBarcode.Barcode.BarcodeScanner;
using System.Drawing;
using System.IO;

namespace Centar
{
    /// <summary>
    /// Interaction logic for WebCamera.xaml
    /// </summary>
    public partial class WebCamera : Window
    {
        public WebCamera()
        {
            InitializeComponent();
            WebcamCtrl.FrameRate = 30;
            WebcamCtrl.FrameSize = new System.Drawing.Size(640, 480);

            var uredjaj = EncoderDevices.FindDevices(EncoderDeviceType.Video);
            
            WebcamCtrl.VideoDevice = uredjaj[0];

            string imagePath = System.IO.Directory.GetCurrentDirectory() + @"\SlikeKamere";

            if (!Directory.Exists(imagePath))
            {
                Directory.CreateDirectory(imagePath);
            }
            WebcamCtrl.ImageDirectory = imagePath;
            

        }


        private String[] ReadBarcodeFromBitmap(Bitmap _bimapimage)
        {
            System.Drawing.Bitmap objImage = _bimapimage;
            String[] barcodes = BarcodeScanner.Scan(objImage, BarcodeType.All);
            return barcodes;
        }
        
        private void buttonUpaliKameru_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                WebcamCtrl.StartCapture();                
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void buttonUgasiKameru_Click(object sender, RoutedEventArgs e)
        {
            WebcamCtrl.StopCapture();
        }


        private void Grid_Unloaded_1(object sender, RoutedEventArgs e)
        {
            buttonUgasiKameru_Click(sender, e);
        }


        private void buttonSlikajBarkod_Click(object sender, RoutedEventArgs e)
        {
            WebcamCtrl.TakeSnapshot();
        }

        public System.Drawing.Image ImageWpfToGDI(System.Windows.Controls.Image image)
        {
            MemoryStream ms = new MemoryStream();
            var encoder = new System.Windows.Media.Imaging.BmpBitmapEncoder();
            encoder.Frames.Add(System.Windows.Media.Imaging.BitmapFrame.Create(image.Source as System.Windows.Media.Imaging.BitmapSource));
            encoder.Save(ms);
            ms.Flush();
            return System.Drawing.Image.FromStream(ms);
        }

        private void ProvjeriBarKodBUtton_Click(object sender, RoutedEventArgs e)
        {
            textBoxBarkod.Text = "";

            Slike s = new Slike();
            List<System.Windows.Controls.Image> slike = s.slicice;


            Bitmap slika = ImageWpfToGDI(s.slicice[slike.Count - 1]) as Bitmap;

            var nesto = ReadBarcodeFromBitmap(slika);
            if (nesto != null)
            {
                for (int i = 0; i < nesto.Length; i++)
                {

                    textBoxBarkod.Text = textBoxBarkod.Text + " " + nesto[i];
                }
            }
        }
        System.Windows.Controls.Image slika = new System.Windows.Controls.Image();
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            // Create OpenFileDialog 
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();


            dlg.DefaultExt = ".png";
            dlg.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";


            // Display OpenFileDialog by calling ShowDialog method 
            Nullable<bool> result = dlg.ShowDialog();


            // Get the selected file name and display in a TextBox 
            if (result == true)
            {
                slika.Source = new BitmapImage(new Uri(dlg.FileName));
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            textBoxBarkod_Copy.Text = "";
            Bitmap sl = ImageWpfToGDI(slika) as Bitmap;

            var nesto = ReadBarcodeFromBitmap(sl);
            if (nesto != null)
            {
                for (int i = 0; i < nesto.Length; i++)
                {

                    textBoxBarkod_Copy.Text = textBoxBarkod_Copy.Text + " " + nesto[i];
                }
            }
        }
    }
}
