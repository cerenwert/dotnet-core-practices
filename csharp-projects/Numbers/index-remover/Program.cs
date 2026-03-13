using System;
using System.IO.Pipelines;

class Program
{
    static void Main()
    {
        Console.Write("Input: ");
        string input = Console.ReadLine();
        string result = RemoveIndexes(input);
        Console.WriteLine("Output: " + result);

    }
}