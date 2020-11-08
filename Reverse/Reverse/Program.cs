using System;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main()
        {
            int Num = 341759;
            Console.WriteLine($"Reverse number is - {reverse(Num)}");
        }

        public static int reverse(int reverse)
        {
            int Reverse = 0;
            while (reverse > 0)
            {
                Reverse = (Reverse * 10) + reverse % 10;
                reverse /= 10;
            }
            return Reverse;
        }

    }
}
