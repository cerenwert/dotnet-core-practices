using System;

class Program
{
    static void Main()
    {
        Console.Write("Input: ");
        string input = Console.ReadLine();
        string [] word= input.Split(' ');
        foreach (char word in words[0])
        {
           Console.WriteLine(
            word.Length>1 
            ? word.Substring(1) + word[0] : word +" "
           );
        }
    }
}
