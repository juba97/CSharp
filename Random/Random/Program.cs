using System;


namespace G06_20201020
{
    class Program
    {
        static void Main()
        {
            Random r = new Random();
            int[] x = new int[100];



            x[0] = r.Next(100);
            Console.WriteLine(x[0]);
            x[1] = r.Next(100);
            Console.WriteLine(x[1]);
            x[2] = r.Next(100);
            Console.WriteLine(x[2]);
            x[3] = r.Next(100);
            Console.WriteLine(x[3]);
            x[4] = r.Next(100);
            Console.WriteLine(x[4]);
            int i = x[0];

            if (x[1] >= i)
            {
                i = x[1];
            }

            if (x[2] >= i)
            {
                i = x[2];
            }

            if (x[3] >= i)
            {
                i = x[3];
            }

            if (x[4] >= i)
            {
                i = x[4];
            }





            //მომიძებნეთ და დამიწერეთ ამ რიცხვებიდან ყველაზე დიდი.
            //გამოვიყენოთ ის რაც ვიცით და არ გამოვიყენოთ ჩაშენებული ფუნქციები.

            Console.WriteLine("largest number = " + i);
            Console.ReadKey();
        }
    }
}