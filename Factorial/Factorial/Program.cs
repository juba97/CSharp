using System;
namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Number : ");
            uint n = uint.Parse(Console.ReadLine());
            uint factorial = (uint)Factorial(n);
            Console.Write($"Factorial of {n} is: {factorial}");

            Console.ReadLine();
        }
        static uint Factorial(uint n)
        {
             if (n == 1)
            {
                return 1;
               
            }
            if (n == 0)
            {
                return 0;
            }
            else
            {
                return n * Factorial(n - 1);
            }
        }
    }
}
