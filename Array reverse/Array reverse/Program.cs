using System;

namespace Array_reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1,2,3,4,5};
            for (int i = 0; i < arr.Length / 2; i++)
            {
                int temp = arr[i];
                arr[i] = arr[arr.Length - (i + 1)];
                arr[arr.Length - (i + 1)] = temp;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
