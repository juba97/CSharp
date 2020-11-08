using System;

namespace Function
{
    class Program
    {
        static void Main(string[] args)
        {
            int Maxs = MaxNumber(1000, 200);
            Console.WriteLine($"LargestNumber is - {Maxs}");
            double Sum = PrintNumber(10.5, 6.3);
            Console.WriteLine($"Sum is - {Sum}");
            int print = Print(6, 6);
            Console.WriteLine($"Multiplication is - {print}");
            programmer();
            int Min = Minnumber(1000, 200);
            Console.WriteLine($"Minnumber is - {Min}");
            
        }
        public static int  MaxNumber(int numbers, int max)
        {
                if (numbers > max)
                {
                    return numbers;
                }
                else
                {
                    return max;
                }                     
        }
        public static int Minnumber(int Minnumbers, int Min)
        {
            if (Minnumbers < Min)
            {
                return Minnumbers;
            }
            else
            {
                return Min;
            }

        }
        public static int Print(int SecondM, int FirstM)
        {
            if ((SecondM > 5) && (FirstM > 5))
            {
                return SecondM * FirstM;
            }
            return 0;
        }
        public static double PrintNumber(double FirstNumber, double SecondNumber) => FirstNumber + SecondNumber;
        public static void programmer()
        {
            Console.WriteLine("I'm a programmer");
        }
    }
}
