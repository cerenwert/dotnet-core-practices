using System;

namespace circle_drawer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int yaricap = InputHelper.YaricapAl();
            CircleDrawer.DaireCiz(yaricap);

            Console.WriteLine();
            Console.WriteLine("Çıkmak için bir tuşa basın...");
            Console.ReadKey();
        }
    }

    internal static class InputHelper
    {
        public static int YaricapAl()
        {
            while (true)
            {
                Console.Write("Lütfen dairenin yarıçapını giriniz: ");
                string? input = Console.ReadLine();
                if (int.TryParse(input, out int yaricap) && yaricap > 0)
                {
                    return yaricap;
                }   
                
                Console.WriteLine("Geçerli bir pozitif tam sayı girmeniz gerekiyor.");
            }
        }
    }
     internal static class CircleDrawer
    {
        public static void DaireCiz(int yaricap)
        {
            double kalinlik = 0.4;
            for(int y=-yaricap; y<=yaricap; y++)
            {
                for(int x=-yaricap; x<=yaricap; x++)
                {
                    double uzaklik = Math.Sqrt(x * x + y * y);
                    if (uzaklik >= yaricap - kalinlik && uzaklik <= yaricap + kalinlik)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }        
}