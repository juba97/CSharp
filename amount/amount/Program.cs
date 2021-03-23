using System;

namespace amount
{
    class Program
    {
        static void Main()
        {
            decimal amount;
            decimal rate_of_return;
            int years, i;
            amount = 1000.0M;
            rate_of_return = 0.07M;
            years = 10;
            Console.WriteLine("Original investment: $" + amount);
            Console.WriteLine("Rate of return: " + rate_of_return);
            Console.WriteLine("Over " + years + " years");
            for (i = 0; i < years; i++)
            {
                amount = amount + (amount * rate_of_return);
            }          
            Console.WriteLine("Future value is $" + amount);
        }
    }
}
