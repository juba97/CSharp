using System;

namespace ConsoleApp117
{
    class Program
    {

        static void Main()
        {
            int[] x = { 3, 4, 5, 6, 7 };
            PrintSum(x);
            int[] i = { 3, 4, 5, 6, 7 };
            int y = PrintAvg(i);
            Console.WriteLine($"Avg is - {y}");
            int[] j = { 3, 4, 5, 6, 7 };
            int b = MaxNumber(j);
            Console.WriteLine($"MaxNumber is - {b}");
            int[] a = { 3, 4, 5, 6, 7 };
            int c = MinNumber(a);
            Console.WriteLine($"MinNumber is - {c}");
        }

        static void PrintSum(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];

            }
            Console.WriteLine($"Sum is - {sum} ");

        }

        static int PrintAvg(int[] array)
        {
            int avg = 0, save = 0;
            for (int i = 0; i < array.Length; i++)
            {
                save += array[i];

            }
            avg = save / array.Length;
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
