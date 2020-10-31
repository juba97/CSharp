using System;
namespace G06_20201027
{
    class Program
    {
        static void Main()
        {
            Random r = new Random();
            int[] x = new int[10];
            for (int i = 0; i < x.Length; i++)
            {
                x[i] = r.Next(15);
            }

            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine(x[i]);
            }

            int n = x.Length;
            Console.WriteLine("Unique array elements: ");
            for (int i = 0; i < n; i++)
            {
                bool Duplicate = false;
                for (int j = 0; j < i; j++)
                {
                    if (x[i] == x[j])
                    {
                        Duplicate = true;
                    }
                }
                if (!Duplicate)
                {
                    Console.WriteLine(x[i]);
                }
            }
        }
    }
}

