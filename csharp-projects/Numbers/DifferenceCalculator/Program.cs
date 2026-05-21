using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Sayıları Girin:");
        string input1 = Console.ReadLine()!;
        int smalltotal = 0;
        int bigtotal = 0;
        string[] numbers = input1.Split(' ');
        foreach (string number in numbers)
        {
            if (int.TryParse(number, out int num))
            {
                if (num < 67)
                {
                    smalltotal +=67 - num;
                }
                else
                {
                    int diff = num - 67;
                    bigtotal += diff* diff;
                }
            }
            else
            {
                Console.WriteLine($"'{number}' geçerli bir sayı değil.");
            }
        }
        Console.WriteLine($"Küçük sayıların toplamı: {smalltotal}");
        Console.WriteLine($"Büyük sayıların toplamı: {bigtotal}");
    }
}