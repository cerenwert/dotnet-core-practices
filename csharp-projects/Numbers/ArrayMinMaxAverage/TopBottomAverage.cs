using System;
using System.Collections;

class Program
{
    static void Main()
    {
        int[] sayilar = new int[20];

        Console.WriteLine("20 adet sayı giriniz");
         for(int i=0; i<=20;i++)
         {
            Console.WriteLine($"{i + 1}.sayı:");
            sayilar[i] = int.Parse(Console.ReadLine());
         }
         Array.Sort(sayilar);
        int kucukToplam = 0;
        int buyukToplam = 0;
        for (int i=0; i<5;i++)
        {
            kucukToplam += sayilar[i];
        }
        for (int i=17; i<20;i++)
        {
            buyukToplam += sayilar[i];
        }

        double kucukortalama= kucukToplam / 3.0;
        double buyukortalama= buyukToplam / 3.0;
        double genelortalama = (kucukortalama+ buyukortalama);
      
        Console.WriteLine("\n--- SONUÇ ---");
        Console.WriteLine($"En küçük 3 sayının ortalaması: {kucukortalama}");
        Console.WriteLine($"En büyük 3 sayının ortalaması: {buyukortalama}");
        Console.WriteLine($"Ortalama toplamı: {genelortalama}");
    }
}

