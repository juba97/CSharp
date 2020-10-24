using System;

namespace Calculatori
{
    class Program
    {
        static void Main(string[] args)
        {
            char symbol1 = 'y';
            do
            {


                Console.WriteLine("Enter First Number");
                double Number = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter Second Number");
                double Number2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter Symbol Operator");
                char Symbol = char.Parse(Console.ReadLine());




                if (Symbol == '+' || Symbol == '-' || Symbol == '*' || Symbol == '/' || Symbol == '%')
                {

                    if (Symbol == '+')
                    {
                        System.Console.WriteLine($"{Number} + {Number2} = {Number + Number2}");
                    }
                    if (Symbol == '-')
                    {
                        System.Console.WriteLine($"{Number} - {Number2} = {Number - Number2}");
                    }
                    if (Symbol == '*')
                    {
                        System.Console.WriteLine($"{Number} * {Number2} = {Number * Number2}");
                    }
                    if (Symbol == '/')
                    {
                        System.Console.WriteLine($"{Number} / {Number2} = {Number / Number2}");
                    }
                    if (Symbol == '%')
                    {
                        System.Console.WriteLine($"{Number} % {Number2} = {Number % Number2}");
                    }
                }

                else
                {
                    System.Console.WriteLine("Error");
                }

                Console.WriteLine("if you want repeat enter 'y'");
                symbol1 = char.Parse(Console.ReadLine());
            } while (symbol1 == 'y');



        }
    }
}