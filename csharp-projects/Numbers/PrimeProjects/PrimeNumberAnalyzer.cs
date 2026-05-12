using System;
using System.Collections;

class Program
{
    static void Main()
    {
        ArrayList asal = new ArrayList();
        ArrayList asalOlmayan = new ArrayList();

        int sayac = 0;

        while (sayac < 20)
        {
            Console.Write($"{sayac + 1}. pozitif sayıyı girin: ");
            int sayi;

            if (int.TryParse(Console.ReadLine(), out sayi) && sayi > 0)
            {
                if (IsPrime(sayi))
                    asal.Add(sayi);
                else
                    asalOlmayan.Add(sayi);

                sayac++;
            }
            else
            {
                Console.WriteLine("Hatalı giriş! Pozitif bir sayı giriniz.");
            }
        }

        asal.Sort();
        asal.Reverse();

        asalOlmayan.Sort();
        asalOlmayan.Reverse();

        Console.WriteLine("\n--- Asal Sayılar ---");
        PrintList(asal);

        Console.WriteLine("\n--- Asal Olmayan Sayılar ---");
        PrintList(asalOlmayan);

       
        Console.WriteLine($"\nAsal sayı adedi: {asal.Count}");
        Console.WriteLine($"Asal sayı ortalaması: {CalculateAverage(asal):F2}");

        Console.WriteLine($"\nAsal olmayan sayı adedi: {asalOlmayan.Count}");
        Console.WriteLine($"Asal olmayan sayı ortalaması: {CalculateAverage(asalOlmayan):F2}");
    }

    static bool IsPrime(int number)
    {
        if (number < 2)
            return false;

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
                return false;
        }

        return true;
    }

    static void PrintList(ArrayList list)
    {
        foreach (var item in list)
            Console.Write(item + " ");
    }

    static double CalculateAverage(ArrayList list)
    {
        if (list.Count == 0)
            return 0;

        double toplam = 0;

        foreach (int item in list)
            toplam += item;

        return toplam / list.Count;
    }
}
