using System;

namespace G06_20202310
{

    class Program
    {

        static void Main(string[] args)
        {

            Random r = new Random();

            int number = r.Next(100, 1000);
            string text = number.ToString();
            char symbol = text[1];

            Console.WriteLine(number);
            Console.WriteLine(symbol);

            //var x = new Random().Next(100, 1000).ToString()[1];
            //Console.WriteLine(x);

        }

    }

}