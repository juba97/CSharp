using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            DrawRectangle1();
            DrawRectangle2();
            DrawRectangle3();
            DrawRectangle4();
            Console.WriteLine("\n");
            Console.ReadKey();
        }

        static void DrawRectangle1()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            for (int y = 5; y < 8; y++)
            {
                Console.SetCursorPosition(5, y);
                Console.Write("         ");
            }

        }

        static void DrawRectangle2()
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            for (int y = 15; y < 18; y++)
            {
                Console.SetCursorPosition(5, y);
                Console.Write("         ");
            }
        }

        static void DrawRectangle3()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            for (int y = 5; y < 8; y++)
            {
                Console.SetCursorPosition(65, y);
                Console.Write("         ");
            }
        }

        static void DrawRectangle4()
        {
            Console.BackgroundColor = ConsoleColor.Green;
            for (int y = 15; y < 18; y++)
            {
                Console.SetCursorPosition(65, y);
                Console.Write("         ");
            }
        }



    }
}
