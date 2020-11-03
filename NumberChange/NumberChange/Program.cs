using System;
namespace ConsoleApp69
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 26;
            int y = 13;
            // gaaketet ise, rom ar gamoiyenot damxmare cvladebi.

            int z;
            z = x;
            x = y;
            y = z;

            
            //x = x + y;
            //y = x - y;
            //x = x - y;


            x = x * y;
            y = x / y;
            x = x / y;
            Console.WriteLine("x = " + x);
            Console.WriteLine("y = " + y);
            Console.ReadKey();
        }
    }
}
