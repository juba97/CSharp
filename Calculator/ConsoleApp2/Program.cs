using System;

namespace ConsoleApp2
{
    class SwitchDemo
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter the first digit -: ");
                int first = int.Parse(Console.ReadLine());
                Console.Write("Select the operator [+, -, *, /] -: ");
                char symbol = char.Parse(Console.ReadLine());
                Console.Write("Enter the second digit -: ");
                int second = int.Parse(Console.ReadLine());


                switch (symbol)
                {
                    case '+':
                        Console.WriteLine($"Result : {first + second}");
                        break;
                }
                switch (symbol)
                {
                    case '-':
                        Console.WriteLine($"Result : {first - second}");
                        break;
                }
                switch (symbol)
                {
                    case '*':
                        Console.WriteLine($"Result : {first * second}");
                        break;
                }
                switch (symbol)
                {
                    case '/':
                        Console.WriteLine($"Result : {first / second}");
                        break;
                }
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception)
            {
                Console.WriteLine("Error");
            }  
        }
    }
}
