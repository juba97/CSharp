using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.Write("Reverse: ");
            //Reverse();
            //Console.Write("Magnitude: ");
            //Magnitude();


            Console.WriteLine();
            Triangle1();
            Console.WriteLine();
            Triangle2();
            Console.WriteLine();
            Triangle3();
        }

        static void Reverse()
        {
            int n = 127;
            int remainder;
            int reverse = 0;
            while (n > 0)
            {
                remainder = n % 10;
                reverse = (reverse * 10) + remainder;
                n = n / 10;
            }
            Console.WriteLine(reverse);
        }

        static void Magnitude()
        {
            int n = 127;
            int mag = 0;
            while (n > 0)
            {
                mag++;
                n = n / 10;
            }
            Console.WriteLine(mag);
        }

        static void Triangle1()
        {

            for (int i = 1; i <= 6; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }


        static void Triangle2()
        {

            int i, j, k;
            for (i = 1; i <= 6; i++)
            {
                for (j = 1; j <= 6 - i; j++)
                {
                    Console.Write(" ");
                }
                for (k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }

        }

        static void Triangle3()
        {

            int i, j, k;

            for (i = 1; i <= 6; i++)
            {
                for (j = 1; j <= 6 - i; j++)
                {

                }
                for (k = 1; k <= j; k++)
                {
                    Console.Write("*");

                }
                Console.WriteLine("");
            }
        }
    }
}