using System;
using System.Runtime.CompilerServices;

namespace Reverse
{
    class Program
    {
        static void Main(string[] args)
        {

            {
                char symbol = 'y';
                do
                {                              

                long number, reverse = 0;
                Console.Write("Enter Number : ");
                number = long.Parse(Console.ReadLine());
                while (number != 0)
                {
                    reverse *= 10;
                    reverse += (number % 10);
                    number = number / 10;
                }
                Console.WriteLine($"Reverse Number is : {reverse}");
                Console.WriteLine("if you want repeat enter 'y' ");
                symbol = char.Parse(Console.ReadLine());
                } while (symbol == 'y');
            }
        }
    }
}
