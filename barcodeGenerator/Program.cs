using System;
using System.IO;
using System.Net.NetworkInformation;
using ZXing;

namespace BarcodeGeneratorReader
{
    class Program
    {
        static void Main(string[] args)
        {
            // Barcode üretmek için bir metin girin
            Console.WriteLine("Barcode üretmek için bir metin girin:");
            string text = Console.ReadLine();

            var writer = new BarcodeWriter
            {
                Format = BarcodeFormat.QR_CODE,
                Options = new ZXing.Common.EncodingOptions
                {
                    Height = 600,
                    Width = 600
                }
            };

           
            var bitmap = writer.Write(text);

            
            string path = @"C:\Users\kivan\Pictures\Saved Pictures\barcode.png";
            bitmap.Save(path);
           
          
            Console.WriteLine($"Barcode dosyası {path} konumuna kaydedildi.");

   
            Console.WriteLine("Barcode okumak için enter tuşuna basın.");
            Console.ReadLine();
      
            var reader = new BarcodeReader();
            var barcodeBitmap = (System.Drawing.Bitmap)System.Drawing.Image.FromFile(path);
     
            var result = reader.Decode(barcodeBitmap);
            Console.WriteLine($"Okunan metin: {result.Text}");
            Console.ReadLine();
        }
    }
}

