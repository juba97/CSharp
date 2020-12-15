using System;

namespace Elections
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] name;
            long[] vote;
            Vote(out name, out vote);
            int Winner = Win(vote, name);
            Console.Write($"\nElections Winner is {name[Winner]} : {vote[Winner]}");
            Console.ReadKey();
        }

            static void Vote(out string[] name, out long[] vote)
            {
                name = new string[8];
                for (int i = 0; i < name.Length; i++)
                {
                    Console.Write((i + 1) + ")" + "Enter Candidate Name: ");
                    name[i] = Console.ReadLine();
                }
                Random x = new Random();

                Console.WriteLine("\n");
                vote = new long[8];
                for (int i = 0; i < name.Length; i++)
                {
                    vote[i] = x.Next(1000000, 3000000);
                }
                for (int i = 0; i < vote.Length; i++)
                {

                    Console.WriteLine($"{name[i]} : {vote[i]}");
                }
            }
        
        public static int Win(long[] vote, string[] name)
        {
            long max = vote[0];
            int j = 0;

            for (int i = 0; i < vote.Length; i++)
            {
                if (max < vote[i])
                {
                    max = vote[i];
                }
            }

            for (int i = 0; i < vote.Length; i++)
            {
                if (vote[i] == max)
                {
                    j = i;
                }
            }
            return j;
        }
    }
}
