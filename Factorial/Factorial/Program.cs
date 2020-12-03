using System;
namespace LogicalPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Number : ");
            int n = int.Parse(Console.ReadLine());
            long factorial = Factorial(n);
            Console.Write($"Factorial of {n} is: {factorial}");

            Console.ReadLine();
        }
        static long Factorial(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return n * Factorial(n - 1);
            }
        }
    }
}