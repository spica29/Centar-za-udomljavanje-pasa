using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Memory
{
    class Slike
    {
        //pravljenje niza od dvadeset slika
        public List<Image> slike = new List<Image>();
        public Slike()
        {
            Image imgTemp;
            List<string> lstFileNames = new List<string>(System.IO.Directory.EnumerateFiles(System.IO.Directory.GetCurrentDirectory() + @"\Slike", "*.jpg"));
            foreach (string fileName in lstFileNames)
            {
                imgTemp = new Image();
                imgTemp.Source = new BitmapImage(new Uri(fileName));
                imgTemp.Height = imgTemp.Width = 100;
                slike.Add(imgTemp);
            }

            Image imgTemp1;
            List<string> lstFileNames1 = new List<string>(System.IO.Directory.EnumerateFiles(System.IO.Directory.GetCurrentDirectory() + @"\Slike", "*.jpg"));
            foreach (string fileName in lstFileNames1)
            {
                imgTemp1 = new Image();
                imgTemp1.Source = new BitmapImage(new Uri(fileName));
                imgTemp1.Height = imgTemp1.Width = 100;
                slike.Add(imgTemp1);
            } 
        }
    }
}
