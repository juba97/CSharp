using System;

namespace Average
{
    class Program
    {
        static void Main(string[] args)
        {
            
                double sum = 0, avg = 0;
                double[] numbers = { 2, 3, 4 };
                for (int i = 0; i < numbers.Length; i++)
                {
                    sum += numbers[i];
                }
                avg = sum / numbers.Length;
                Console.WriteLine("The Sum is : " + sum);
                Console.WriteLine("The Average is : " + avg);

               
            
        }
    }
}
