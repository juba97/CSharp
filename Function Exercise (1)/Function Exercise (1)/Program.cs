using System;
namespace ConsoleApp117
{
    class Program
    {
        static void Main()
        {
            int[] x = { 3, 4, 5, 6, 7 };
            int xSum = GetSum(x);
            double xAvg = GetAverage(x);
            int b = MaxNumber(x);
            int c = MinNumber(x);

            Console.WriteLine($"Sum is - {xSum}");
            Console.WriteLine($"Avg is - {xAvg}");
            Console.WriteLine($"MaxNumber is - {b}");
            Console.WriteLine($"MinNumber is - {c}");
        }
        static int GetSum(int[] array)
        {
            if (array == null)
            {
                return 0;

            }
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];

            }
            return sum;
        }
        static double GetAverage(int[] array)
        {
            int sum = GetSum(array);
            double avg = (double)sum / array.Length;
            return avg;
        }
        static int MaxNumber(int[] array)
        {
            int maxnumber = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > maxnumber)
                {
                    maxnumber = array[i];
                }
            }
            return maxnumber;
        }
        static int MinNumber(int[] array)
        {
            int minnumber = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < minnumber)
                {
                    minnumber = array[i];
                }
            }

            return minnumber;
        }
    }
}
