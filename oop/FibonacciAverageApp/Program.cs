using System;
using System.Collections.Generic;

namespace FibonacciAverageApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int depth = GetDepthFromUser();
            List<int> fibonacciNumbers = GenerateFibonacciSeries(depth);
            double average = CalculateAverage(fibonacciNumbers);

            PrintSeries(fibonacciNumbers);
            PrintAverage(average);
        }

        static int GetDepthFromUser()
        {
            while (true)
            {
                Console.WriteLine("Fibonacci serisinin derinliğini giriniz: ");
                string? input = Console.ReadLine();
                if (int.TryParse(input, out int depth) && depth > 0)
                {
                    return depth;
                }
                Console.WriteLine("Lütfen geçerli bir pozitif tam sayı giriniz."); 
            }
            static List<int> GenerateFibonacciSeries(int depth)
            {
                 List<int> series = new List<int>();

                if (depth >= 1)
                series.Add(0);

                if (depth >= 2)
                series.Add(1);
                for (int i = 2; i < depth; i++)
                {
                    series.Add(series[i - 1] + series[i - 2]);
                }
                return series;
        
            }

            static double CalculateAverage(List<int>members)
            {
                if(members.Count==0)
                {
                    return 0;
                }
                double sum=0;
                foreach(int number in members)
                {
                    sum+=number;
                }
                return sum/members.Count;
            }
            static void PrintSeries (List<int> series)
            {
                Console.WriteLine("Fibonacci Serisi:");
                foreach (int number in series)
                {
                    Console.Write(number + " ");
                }
                Console.WriteLine();
            }
            static void PrintAverage(double average)
            {
                Console.WriteLine($"Fibonacci serisinin ortalaması: {average}");
            }
        }

    }
}