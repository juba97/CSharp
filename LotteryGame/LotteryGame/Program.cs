using System;
using System.Linq;

namespace ConsoleApp3
{
    class Program
    {
        static void Main()
        {
            int[] Lottery = new int[5];
            int[] Guessing = new int[5];
            Random r = new Random();
            for (int i = 0; i < Lottery.Length; i++)
            {
                int temp;
                do
                {
                    temp = r.Next(1, 50);
                }
                while (Lottery.Contains(temp));

                Lottery[i] = temp;
            }
            int Guess = GetLottery(Lottery, Guessing);
            Console.WriteLine($"\nYou Guessed it \'{Guess}\' Digits");

        }
        static int GetLottery(int[] Lottery, int[] Guessing)
        {
            for (int i = 0; i < Guessing.Length; i++)
            {
                Console.Write((i + 1) + ". " + "Enter Numbers: ");
                Guessing[i] = Convert.ToInt32(Console.ReadLine());
            }
            int Guess = 0;
            Console.WriteLine("\nLottery Game");
            for (int i = 0; i < Lottery.Length; i++)
            {
                Console.WriteLine(Lottery[i]);
                for (int j = 0; j < Guessing.Length; j++)
                {
                    if (Lottery[i] == Guessing[j])
                    {
                        Guess++;
                    }
                }
            }
            return Guess;
        }

    }
}



