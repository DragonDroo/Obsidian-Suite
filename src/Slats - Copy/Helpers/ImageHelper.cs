using System;
using System.IO;
using System.Windows;
using System.Windows.Media.Imaging;

namespace Slats.Helpers
{
    public static class ImageHelper
    {
        public static BitmapImage ImageFromString(string data)
        {
            var image = new BitmapImage();
            byte[] binaryData = Convert.FromBase64String(data);
            image.BeginInit();
            image.StreamSource = new MemoryStream(binaryData);
            image.EndInit();
            return image;
        }

        public static BitmapImage ImageFromAssetsFile(string fileName)
        {
            //ToDo: remedy pack resolution
            //var imageUri = new Uri($"pack://Application:,,,/Slats/Assets/{fileName}");
            var imageUri = new Uri($"C:/Users/VHASBYMeachD/source/repos/Service-Line-Admin-Tools/src/Slats/Assets/{fileName}");
            //MessageBox.Show(imageUri.Ur ToString());
            var image = new BitmapImage(imageUri);
            return image;
        }
    }
}
