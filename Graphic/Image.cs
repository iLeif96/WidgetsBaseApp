using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace iLeif.Graphic
{
    public class Image
    {
        public Stream StreamSource { get; private set; }

        public string ImageResourceName { get; private set; }
        public int Height { get; private set; }
        public int Width { get; private set; }

        public Image(int width, int height)
        {
            SetSize(width, height);
        }

        public Image(int width, int height, string imageResourceName)
        {
            SetSize(width, height);
            SetFromResource(imageResourceName);
        }

        public void SetSize(int width, int height)
        {
            Height = height;
            Width = width;
        }

        public void SetFromResource (string imageResourceName)
        {
            StreamSource = Assembly.GetExecutingAssembly().GetManifestResourceStream(imageResourceName);
            ImageResourceName = imageResourceName;
        }
    }
}

//public static BitmapImage LoadImage(string imageName, int Height, int Width)
//{
//    BitmapImage image = new BitmapImage();
//    image.BeginInit();
//    image.StreamSource = Assembly.GetExecutingAssembly().GetManifestResourceStream(imageName);
//    image.DecodePixelHeight = Height;
//    image.DecodePixelWidth = Width;
//    image.EndInit();
//    return image;
//}
