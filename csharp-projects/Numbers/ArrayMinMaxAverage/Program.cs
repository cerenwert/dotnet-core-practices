using System;

class Program
{
    static void Main()
    {
        Console.Write("Kaç adet sayı girmek istiyorsunuz: ");
        int adet = int.Parse(Console.ReadLine()!);

        int[] sayilar = new int[adet];

        for (int i = 0; i < adet; i++)
        {
            Console.Write($"{i + 1}. sayı: ");
            sayilar[i] = int.Parse(Console.ReadLine()!);
        }

        Array.Sort(sayilar);

        int kucukToplam = 0;
        int buyukToplam = 0;

        for (int i = 0; i < 3; i++)
        {
            kucukToplam += sayilar[i];
        }

        for (int i = adet - 3; i < adet; i++)
        {
            buyukToplam += sayilar[i];
        }

        double kucukOrtalama = kucukToplam / 3.0;
        double buyukOrtalama = buyukToplam / 3.0;

        double toplamOrtalama = kucukOrtalama + buyukOrtalama;

        Console.WriteLine("\n--- SONUÇ ---");

        Console.WriteLine($"En küçük 3 sayının ortalaması: {kucukOrtalama}");

        Console.WriteLine($"En büyük 3 sayının ortalaması: {buyukOrtalama}");

        Console.WriteLine($"Ortalama toplamı: {toplamOrtalama}");
    }
}