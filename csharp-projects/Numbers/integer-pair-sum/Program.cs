using System;

namespace Numbers
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the first integer:");
            int num1 = ReadInteger();

            Console.WriteLine("Enter the second integer:");
            int num2 = ReadInteger();

            if (num1 == num2)
            {
                int sum = num1 + num2;
                Console.WriteLine($"The square of the sum is: {sum * sum}");
            }
            else
            {
                int sum = num1 + num2;
                Console.WriteLine($"The sum is: {sum}");
            }
        }

        static int ReadInteger()
        {
            return int.TryParse(Console.ReadLine(), out int result) ? result : 0;
        }
    }
}