using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using ArabaKiralama.Managers;
namespace ArabaKiralama
{
    class Program
    {
        static void Main()
        {
            List<Araba> arabalar=new List<Araba>
            {
                new Araba("Toyota", "Corolla"),
                new Araba("Honda", "Civic"),
                new Araba("Ford", "Focus"),
                new Araba("BMW", "3 Serisi"),
                new Araba("Mercedes", "C Serisi"),

            };
            Musteri musteri = new Musteri
            {
                Ad = "Umut",
                Soyad = "Ateş",
                Telefon = "555-1234",
                Email = "umut.ates@example.com"
            };
           
            KiralamaManager manager = new KiralamaManager(arabalar);
            bool devam = true;
            while (devam)
            {
                
                Console.WriteLine("1.Araba Listesi");
                Console.WriteLine("2.Araba Kirala");
                Console.WriteLine("3.Araba Teslim Et");
                Console.WriteLine("4.Çıkış");
                Console.Write("Seçiminiz: ");
            
                if(!int.TryParse(Console.ReadLine(), out int secim))
                    {
                        Console.WriteLine("Geçersiz giriş.");
                        break;
                    }
                switch (secim)
                {
                    case  1:
                        manager.ArabaListesi();
                        break;
                    case 2:
                        manager.AracKirala(musteri);
                        break;
                    case 3:
                        manager.AracıTeslimEt(musteri);
                        break;
                    case 4:
                        devam = false;
                        Console.WriteLine("Çıkış yapılıyor...");
                        break;
                    default:
                        Console.WriteLine("Geçersiz seçim. Lütfen tekrar deneyin.");
                        break;
                }
            }

            Console.WriteLine("Müşteriadı Soyadı: " + musteri.Ad + " " + musteri.Soyad);
            if (musteri.KiraladigiArac != null)
                {
                    Console.WriteLine("Kiraladığı Araç: " + musteri.KiraladigiArac.Marka + " " + musteri.KiraladigiArac.Model);
                }
                else
                {
                    Console.WriteLine("Kiraladığı Araç: Yok");
                }
            }
        }
        
    }

