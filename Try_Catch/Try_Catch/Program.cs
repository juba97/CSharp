using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter Number : ");
                int N1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter another Number : ");
                int N2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(N1 / N2);
            }
            catch (DivideByZeroException e)
            {

                Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {

                Console.WriteLine("\nDone!");
            }

        }
    }
}
