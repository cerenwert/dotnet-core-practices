using System;

class Program
{
    static void Main(string[] args)
    {
        int size = GetTriangleSize();
        DrawPyramid(size);
    }

    static int GetTriangleSize()
    {
        Console.Write("Üçgenin boyutunu giriniz: ");
        return int.Parse(Console.ReadLine()!);
    }

    static void DrawPyramid(int size)
    {
        for (int i = 1; i <= size; i++)
        {
            PrintSpaces(size - i);
            PrintStars(2 * i - 1);
            Console.WriteLine();
        }
    }

    static void PrintStars(int count)
    {
        for (int i = 0; i < count; i++)
        {
            Console.Write("*");
        }
    }

    static void PrintSpaces(int count)
    {
        Console.Write(new string(' ', count));
    }
}