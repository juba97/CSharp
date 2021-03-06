using System;

namespace ConsoleApp2
{
    class SwitchDemo
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter the first digit : ");
                int first = int.Parse(Console.ReadLine());
                Console.Write("Select the operator [+, -, *, /] : ");
                char symbol = char.Parse(Console.ReadLine());
                Console.Write("Enter the second digit : ");
                int second = int.Parse(Console.ReadLine());


                switch (symbol)
                {
                    case '+':
                        Console.WriteLine();
                        Console.WriteLine($"Sum : {first + second}");
                        break;
                }
                switch (symbol)
                {
                    case '-':
                        Console.WriteLine();
                        Console.WriteLine($"Sub : {first - second}");
                        break;
                }
                switch (symbol)
                {
                    case '*':
                        Console.WriteLine();
                        Console.WriteLine($"Mult : {first * second}");
                        break;
                }
                switch (symbol)
                {
                    case '/':
                        Console.WriteLine();
                        Console.WriteLine($"Div : {first / second}");
                        break;
                }
                switch (symbol)
                {
                    case '%':
                        Console.WriteLine();
                        Console.WriteLine($"Rem : {first % second}");
                        break;
                }
            }
            catch (DivideByZeroException e)
            {            
                Console.WriteLine(e.Message);
            }
            catch (Exception)
            {
                Console.WriteLine();
                Console.WriteLine("Unknown number or operator");
            }
        }
    }
}
