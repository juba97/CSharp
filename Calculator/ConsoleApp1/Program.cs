using System;
class program
{
    static void Main()
    {
        try
        {
            Console.Write("Enter the first digit -: ");
            int first = int.Parse(Console.ReadLine());
            Console.Write("Select the operator [+, -, *, /] -: ");
            char symbol = char.Parse(Console.ReadLine());
            Console.Write("Enter the second digit -: ");
            int second = int.Parse(Console.ReadLine());
            
            
            if (symbol == '+')
            {
                Console.Write($"Sum = {first + second}");
            }
            else if (symbol == '-')
            {
                Console.Write($"Sub = {first - second}");
            }
            else if (symbol == '*')
            {
                Console.Write($"Mult = {first * second}");
            }
            else if (symbol == '/')
            {
                Console.Write($"Div = {first / second}");
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