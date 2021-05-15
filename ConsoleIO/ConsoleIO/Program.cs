using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace ConsoleIO
{
    class Program
    {
        const string path = @"D:\Text.txt";

        static void Main(string[] args)
        {
            //Append();
            //Read();
            //Delete(path, Console.ReadLine());
            //Replace(path, Console.ReadLine(), Console.ReadLine());    
        }
        static void Read()
        {
            StreamReader sr = new StreamReader(path);
            while (sr.ReadLine() is string s)
            {
                Console.WriteLine(s);
            }
            sr.Close();
        }

        static void Append()
        {
            StreamWriter sw = new StreamWriter(path, true);
            sw.WriteLine(Console.ReadLine());
            sw.Dispose();
        }

        static void Delete(string filename, string searchText)
        {

            bool searchTextFound = true;
            var filteredLines = File.ReadLines(filename).Where(line => !(searchTextFound = line.Contains(searchText)));

            if (searchTextFound)
            {
                string destFilename = Path.GetTempFileName();
                File.WriteAllLines(destFilename, filteredLines);
                File.Delete(filename);
                File.Move(destFilename, filename);
            }
        }

        static void Replace(string filePath, string searchText, string replaceText)
        {
            StreamReader reader = new StreamReader(path);
            string content = reader.ReadToEnd();
            reader.Close();
            content = Regex.Replace(content, searchText, replaceText);

            StreamWriter writer = new StreamWriter(filePath);
            writer.Write(content);
            writer.Close();
        }
    }
}