using System;
using System.Diagnostics;
using System.Threading;

class Program
{
    static void Main()
    {
        Stopwatch sw = new Stopwatch();
        bool running = true;

        Console.WriteLine("S = Start | T = Stop | R = Reset | Q = Quit");

        while (running)
        {
            if (Console.KeyAvailable)
            {
                var key = Console.ReadKey(true).Key;

                switch (key)
                {
                    case ConsoleKey.S:
                        sw.Start();
                        break;

                    case ConsoleKey.T:
                        sw.Stop();
                        break;

                    case ConsoleKey.R:
                        sw.Reset();
                        break;

                    case ConsoleKey.Q:
                        running = false;
                        break;
                }
            }

            Console.SetCursorPosition(0, 2);
            Console.Write(sw.Elapsed.ToString(@"hh\:mm\:ss"));
            Thread.Sleep(200);
        }
    }
}
