using System;

namespace GROUP06_1272020
{
    class Program
    {

        static void Main()
        {
            string[] names = { "George", "John", "Nick" };
            //Array.Resize(ref names, 4);
            names = (string[])Resize(ref names, 4);
            names[3] = "Jessica";
            

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }

        }
        static Array Resize(ref string[] oldArray, int newSize)
        {
            int oldSize = oldArray.Length;
            Type elementType = oldArray.GetType().GetElementType();
            Array newArray = Array.CreateInstance(elementType, newSize);

            int Length = Math.Min(oldSize, newSize);

            if (Length > 0)
                Array.Copy(oldArray, newArray, Length);

            return newArray;
        }
    }
}