using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Bir cümle giriniz: ");
        string cumle = Console.ReadLine().ToLower();

        char[] sesliHarfler = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };
        List<char> bulunansesliler = new List<char>();
        foreach (char harf in cumle)
        {
            if(Array.IndexOf(sesliHarfler,harf)!=-1)
            {
                bulunansesliler.Add(harf);
            }
        }
        char[]sonucdizi=bulunansesliler.ToArray();
        Array.Sort(sonucdizi);

        Console.WriteLine("Cümledeki sesli harfler:");
        foreach (char harf in sonucdizi)
        {
            Console.Write(harf + " ");
        }
    }
}
