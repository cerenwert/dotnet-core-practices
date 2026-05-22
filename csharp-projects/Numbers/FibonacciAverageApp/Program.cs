using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Kaç adet Fibonacci sayısı üretilecek: ");
        int count = int.Parse(Console.ReadLine()!);
        int first= 0, second = 1;
        int total = 0;
        Console.Write("Fibonacci Sayıları: ");
        for (int i = 0; i < count; i++)
        {
            Console.Write(first + " ");
            total += first;
            int next = first + second;
            first = second;
            second = next;
        }
        double average = (double)total / count;
        Console.WriteLine($"\nFibonacci Sayılarının Ortalaması: {average}");
    }
}