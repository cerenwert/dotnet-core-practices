using System;
using System.Collections.Specialized;
using System.IO.Pipelines;

class Program
{
    static void Main()
    {
        Console.Write("yazınız: ");
        string input = Console.ReadLine()!;
        string result = RemoveIndexes(input);
        Console.WriteLine("Output: " + result);

    }
    static string RemoveIndexes(string input)
    {
        string[] parts = input.Split(' ');
        string word = parts[0];
        int index = int.Parse(parts[1]);
        if (index < 0 || index >= word.Length)
        {
            Console.WriteLine("Geçersiz indeks!");
            return word;
        }
        return word.Remove(index, 1);
    }
}