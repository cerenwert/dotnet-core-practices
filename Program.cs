using System;

class Program
{
    static void Main()
    {
        Console.Write("Input: ");
        string input = Console.ReadLine();
        string [] words= input.Split(' ');
        foreach (string word in words)
        {
           Console.WriteLine(
             word.Length>1 
             ? word.Substring(1) + word[0] 
                : word +" "
         );
        }
    }
}