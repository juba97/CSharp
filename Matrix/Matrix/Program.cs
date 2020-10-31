using System;
namespace G06_20201027
{
    class program
    {
        static void Main()
        {
            Random r = new Random();
            int[,] x = new int[10, 8];

            for (int i = 0; i < x.GetLength(0); i++)
            {
                for (int j = 0; j < x.GetLength(1); j++)
                {
                    x[i, j] = r.Next(100, 1000);

                    Console.Write(x[i, j] + " ");
                }
                Console.WriteLine();
            }
            int sum = 0;
            for (int i = 0; i < x.GetLength(0); i++)
            {
                for (int j = 0; j < x.GetLength(1); j++)
                {
                    sum += x[i, j];

                }

            }
            Console.WriteLine("Sum = " + sum);
            int max = x[0, 0];
            for (int i = 0; i < x.GetLength(0); i++)
            {
                for (int j = 0; j < x.GetLength(1); j++)
                {

                    if (x[i, j] > max)
                    {

                        max = x[i, j];
                    }
                }
            }
            Console.WriteLine("Max = " + max);
            int min = x[0, 0];
            for (int i = 0; i < x.GetLength(0); i++)
            {
                for (int j = 0; j < x.GetLength(1); j++)
                {
                    if (x[i, j] < min)
                    {
                        min = x[i, j];
                    }
                }
            }
            Console.WriteLine("Min = " + min);
            double avg = (double)sum / x.Length;
            Console.WriteLine("Avg = " + avg);
            Console.ReadKey();
        }
    }
}