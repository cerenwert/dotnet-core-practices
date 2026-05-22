using System;

class Program
{
    static void Main()
    {
        Console.Write("Input: ");

        string input = Console.ReadLine()!;

        string[] words = input.Split(' ');

        foreach (string word in words)
        {
            bool sonuc = HasDoubleConsonant(word);

            Console.Write(sonuc + " ");
        }
    }
     static bool HasDoubleConsonant(string word)
    {
        string sessizler = "bcçdfgğhjklmnprsştvyzxqw";
        for (int i = 0; i < word.Length - 1; i++)
        {
            char first = char.ToLower(word[i]);
            char second = char.ToLower(word[i + 1]);

            if (sessizler.Contains(first) && sessizler.Contains(second))
            {
                return true;
            }
        }

        return false;
    }
}