using System;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // int z = 4;
            // int b = 10;
            // GetMaxValue(z, b);

            System.Console.WriteLine(ReturnLengthName("macivari", "skami"));
        }


        public static /*დამაბრუნებელი მნიშვნელობდა => */ int /*ფუნქციის სახელი => */ GetMaxValue(int x, int y) //<= ფუნქციის პარამეტრები
        {
            if(x > y)
            {
                return x;
            }
            else
            {
                return y;
            }
        }

        public static string ReturnLengthName(string firstName, string secondName)
        {
            return $"{firstName} and {secondName}";
        }
    }
}


