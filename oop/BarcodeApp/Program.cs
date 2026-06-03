using System;
using System.Drawing;
using System.Drawing.Imaging;
using ZXing;
using ZXing.Common;
using ZXing.Windows.Compatibility;
class Program
{
    static void Main(string[] args)
    {
        
        while (true)
        {
            
            Console.WriteLine("\n===== BARKOD UYGULAMASI =====");
            Console.WriteLine("1 - Barkod Oluştur");
            Console.WriteLine("2 - Barkod Oku");
            Console.WriteLine("3 - Çıkış");

            Console.Write("Seçiminiz: ");
            string? choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateBarcode();
                    break;

                case "2":
                    ReadBarcode();
                    break;

                case "3":
                    return;

                default:
                    Console.WriteLine("Geçersiz seçim.");
                    break;
            }
        }
    }
    public static void CreateBarcode()
    {
        Console.WriteLine("Barkod verisini girin:");
        string? data =Console.ReadLine();
        if(string.IsNullOrEmpty(data))
        {
            Console.WriteLine("Barkod verisi boş olamaz.");
            return;
        }
        else
        {
            var writer = new BarcodeWriter
            {
                Format = BarcodeFormat.CODE_128,
                Options = new EncodingOptions
                {
                    Height = 100,
                    Width = 300
                }
            };
            using (var bitmap= writer.Write(data))
            {
                string filePath  = "barcode.png";
                bitmap.Save(filePath ,ImageFormat.Png);
                Console.WriteLine($"Barkod '{filePath}' olarak kaydedildi.");
            }
        }
    }
    public static void ReadBarcode()
    {
        string filePath="barcode.png";
        if(!filePath.EndsWith(".png",StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("Lütfen geçerli bir PNG dosyası seçin.");
            return;
        }
        else
        {
            var reader = new BarcodeReader();
            using var bitmap=(Bitmap)Image.FromFile(filePath);
            {
                var result=reader.Decode(bitmap);
                if(result!=null)
                {
                    Console.WriteLine($"Barkod Verisi: {result.Text}");
                }
                else
                {
                    Console.WriteLine("Barkod okunamadı.");
                }
            }
        }
        
    }
    
}