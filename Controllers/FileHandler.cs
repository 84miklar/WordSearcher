using System;

namespace WordSearcher.Controller
{
    internal class FileHandler
    {
        public static void GetDataFromTexFile()
        {
            string fileName = "TestTextFile1.txt";
            string text = System.IO.File.ReadAllText(fileName);

            System.Console.WriteLine("Contents of TestTextFile1.txt = {0}", text);
            MakeTextIntoArray(text); // gånger 3
        }

        public static void MakeTextIntoArray(string text)
        {
            char[] separators = new char[] { ' ', '.', ',' };
            string[] textArray = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            foreach (string word in textArray)
            {
                Console.WriteLine(word);
            }
        }
    }
}