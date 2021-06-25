using System;
using System.IO;
using System.IO.Compression;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Controls;

using Slats.ViewModels;

namespace Slats.Views
{
    /// <summary>
    /// Interaction logic for SignInConnect.xaml
    /// </summary>
    /// 



    public class CryptoEngine
    {
        public static string Encrypt(string input, string key)
        {
            byte[] inputArray = UTF8Encoding.UTF8.GetBytes(input);
            TripleDESCryptoServiceProvider tripleDES = new TripleDESCryptoServiceProvider();
            tripleDES.Key = UTF8Encoding.UTF8.GetBytes(key);
            tripleDES.Mode = CipherMode.ECB;
            tripleDES.Padding = PaddingMode.PKCS7;
            ICryptoTransform cTransform = tripleDES.CreateEncryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(inputArray, 0, inputArray.Length);
            tripleDES.Clear();
            return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        }
        public static string Decrypt(string input, string key)
        {
            byte[] inputArray = Convert.FromBase64String(input);
            TripleDESCryptoServiceProvider tripleDES = new TripleDESCryptoServiceProvider();
            tripleDES.Key = UTF8Encoding.UTF8.GetBytes(key);
            tripleDES.Mode = CipherMode.ECB;
            tripleDES.Padding = PaddingMode.PKCS7;
            ICryptoTransform cTransform = tripleDES.CreateDecryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(inputArray, 0, inputArray.Length);
            tripleDES.Clear();
            return UTF8Encoding.UTF8.GetString(resultArray);
        }
    }

    public partial class SignInConnect : Page
    {
        public string something;
        public SignInConnect(SignInConnectVM viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
            something = "something";
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            something = RawText.Text;
            HaschCodeT.Text = something.GetHashCode().ToString();
        }

        private void Button_Click_1(object sender, System.Windows.RoutedEventArgs e)
        {
            something = RawText.Text;
            CypherText.Text = CryptoEngine.Encrypt(something, "sblw-3hn8-sqoy19");
        }

        private void Button_Click_2(object sender, System.Windows.RoutedEventArgs e)
        {
            something = RawText.Text;
            //Compressedtext.Text = StringCompressor.CompressString(something);
            Compressedtext.Text = Compressor.Compress(something);

        }
    }

    internal static class StringCompressor
    {
        /// <summary>
        /// Compresses the string.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <returns></returns>
        public static string CompressString(string text)
        {
            byte[] buffer = Encoding.UTF8.GetBytes(text);
            var memoryStream = new MemoryStream();
            using (var gZipStream = new GZipStream(memoryStream, CompressionMode.Compress, true))
            {
                gZipStream.Write(buffer, 0, buffer.Length);
            }

            memoryStream.Position = 0;

            var compressedData = new byte[memoryStream.Length];
            memoryStream.Read(compressedData, 0, compressedData.Length);

            var gZipBuffer = new byte[compressedData.Length + 4];
            Buffer.BlockCopy(compressedData, 0, gZipBuffer, 4, compressedData.Length);
            Buffer.BlockCopy(BitConverter.GetBytes(buffer.Length), 0, gZipBuffer, 0, 4);
            return Convert.ToBase64String(gZipBuffer);
        }

        /// <summary>
        /// Decompresses the string.
        /// </summary>
        /// <param name="compressedText">The compressed text.</param>
        /// <returns></returns>
        public static string DecompressString(string compressedText)
        {
            byte[] gZipBuffer = Convert.FromBase64String(compressedText);
            using (var memoryStream = new MemoryStream())
            {
                int dataLength = BitConverter.ToInt32(gZipBuffer, 0);
                memoryStream.Write(gZipBuffer, 4, gZipBuffer.Length - 4);

                var buffer = new byte[dataLength];

                memoryStream.Position = 0;
                using (var gZipStream = new GZipStream(memoryStream, CompressionMode.Decompress))
                {
                    gZipStream.Read(buffer, 0, buffer.Length);
                }

                return Encoding.UTF8.GetString(buffer);
            }
        }
    }

    public static class Compressor
    {

        /// &lt;summary&gt;
        /// Use this to compress UTF-8 string to Base-64 string.
        /// &lt;/summary&gt;
        /// &lt;param name="text"&gt;The string value to compress.&lt;/param&gt;
        /// &lt;returns&gt;&lt;/returns&gt;
        public static string Compress(this string text)
        {
            var buffer = Encoding.UTF8.GetBytes(text);
            var memoryStream = new MemoryStream();
            using (var stream = new GZipStream(memoryStream, CompressionMode.Compress, true))
            {
                stream.Write(buffer, 0, buffer.Length);
            }
            memoryStream.Position = 0;
            var compressed = new byte[memoryStream.Length];
            memoryStream.Read(compressed, 0, compressed.Length);
            var gZipBuffer = new byte[compressed.Length + 4];
            Buffer.BlockCopy(compressed, 0, gZipBuffer, 4, compressed.Length);
            Buffer.BlockCopy(BitConverter.GetBytes(buffer.Length), 0, gZipBuffer, 0, 4);
            return Convert.ToBase64String(gZipBuffer);
        }

        /// &lt;summary&gt;
        /// Use this to decompress Base-64 string to UTF-8 string.
        /// &lt;/summary&gt;
        /// &lt;param name="compressedText"&gt;&lt;/param&gt;
        /// &lt;returns&gt;&lt;/returns&gt;
        public static string Decompress(this string compressedText)
        {
            var gZipBuffer = Convert.FromBase64String(compressedText);
            using (var memoryStream = new MemoryStream())
            {
                int dataLength = BitConverter.ToInt32(gZipBuffer, 0);
                memoryStream.Write(gZipBuffer, 4, gZipBuffer.Length - 4);
                var buffer = new byte[dataLength];
                memoryStream.Position = 0;
                using (var gZipStream = new GZipStream(memoryStream, CompressionMode.Decompress))
                {
                    gZipStream.Read(buffer, 0, buffer.Length);
                }
                return Encoding.UTF8.GetString(buffer);
            }
        }
    }
}
