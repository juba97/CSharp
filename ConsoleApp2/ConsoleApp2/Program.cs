using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = 
            {
                1, 
                2, 
                3,
                4,
                5, 
            };

            int[] reverse = new int[numbers.Length];
            int j = numbers.Length - 1;

            for (int i = 0; i < numbers.Length; i++)
            {

                reverse[i] = numbers[j];               
                j--;
                Console.WriteLine(reverse[i]);
            }
        }
    }
}
