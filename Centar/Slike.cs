using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Centar
{
    public class Slike
    {
        public List<Image> slicice = new List<Image>();

        public Slike()
        {

            Image imgTemp;
            List<string> lstFileNames = new List<string>(System.IO.Directory.EnumerateFiles(System.IO.Directory.GetCurrentDirectory() + @"\SlikeKamere", "*.jpg"));
            foreach (string fileName in lstFileNames)
            {
                imgTemp = new Image();
                imgTemp.Source = new BitmapImage(new Uri(fileName));
                imgTemp.Height = imgTemp.Width = 100;
                slicice.Add(imgTemp);
            }

        }

    }
}
