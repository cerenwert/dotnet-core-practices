<<<<<<< HEAD
﻿using System;

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
=======
﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
>>>>>>> 8724e699eda1a3543fdb6bab750e618216bc1cd5
