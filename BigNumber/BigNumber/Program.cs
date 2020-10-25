using System;

namespace G06_20202310_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            Random r = new Random();
            int max;

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = r.Next(1, 100);
                Console.WriteLine($"numbers[{i}] = {numbers[i]}");
            }

            max = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {

                if (max < numbers[i])
                    max = numbers[i];
            }

            Console.WriteLine("largest number - " + max);

        }
    }
}