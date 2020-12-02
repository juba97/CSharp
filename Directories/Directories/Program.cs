using System;

using System.IO;
namespace G03_2020_11_23
{
    class Program
    {
        static void Main()
        {
            string[] dirs = WriteDirectories();
            for (int i = 0; i < dirs.Length; i++)
            {
                string dir = dirs[i];
                Console.WriteLine(dir);
            }
            Console.ReadKey();
        }

        static string[] WriteDirectories()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            string[] dirs = Directory.GetDirectories(@"D:\Games\Need For Speed Heat", "", SearchOption.AllDirectories);
            return dirs;
        }
    }
}
