using System;

namespace G06_20202310_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            Random r = new Random();
            int min;

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = r.Next(1, 100);
                Console.WriteLine(numbers[i]);
            }
            min = numbers[0];
            
            for (int i = 1; i < numbers.Length; i++)
            {
                if (min > numbers[i])
                    min = numbers[i];
                
            }

            
            Console.WriteLine("Min number -  " + min);

        }
    }
}

