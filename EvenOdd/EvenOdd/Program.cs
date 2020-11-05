using System;
namespace G06_20201027
{
    class Program
    {
        static void Main()
        {
            Random r = new Random();
            int[] numbers = new int[10];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = r.Next(100);
                string text;
                if (numbers[i] == 0)
                {
                    text = "Zero";
                }
                else if (numbers[i] % 2 == 0)
                {
                    text = "Even";
                }
                else
                {
                    text = "Odd";
                }
                Console.WriteLine($"numbers[{i}] = {numbers[i]} | {text}");
            }

            int j, even = 0, odd = 0;
            for (j = 0; j < numbers.Length; j++)
            {
                if (numbers[j] % 2 == 0)
                {
                    even += numbers[j];

                }
                else
                {
                    odd += numbers[j];

                }
            }
            Console.WriteLine($"Even sum is {even}");
            Console.WriteLine($"odd sum is {odd}");         

            int min, max;        
            min = numbers[0];
            max = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (min > numbers[i])
                    min = numbers[i];
                if (max < numbers[i])
                    max = numbers[i];
            }
            Console.WriteLine($"Max numbers is {max}");
            Console.WriteLine($"Min numbers is {min}");

            double avg = (double)even / numbers.Length;        
            Console.WriteLine($"Avg even number is {avg}");
            double avg1 = (double)odd / numbers.Length;
            Console.WriteLine($"Avg odd number is {avg1}");
            Console.ReadKey();
            }
        }
    }
