using System;

namespace ChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = ChanegeNumbers(new[] { 3, 6, 1, 9, 2 });
            Console.WriteLine("Change numbers is");
            foreach (var a in array)
            {
                Console.Write(a.ToString() + " ");
                
            }
           
        }
        static int[] ChanegeNumbers(int[] numbers)
        {
            int first = numbers[0];
            numbers[0] = numbers[numbers.Length - 1];
            numbers[numbers.Length - 1] = first;

            return numbers;

            
        }

        
    }
}
