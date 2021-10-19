using System;
using WordSearcher.Model;

namespace WordSearcher.Controller
{
     class FileHandler
    {
        /// <summary>
        /// läser in 3 textfiler och sparar dem i model Arrays
        /// </summary>
        public static void GetDataFromTexFile()
        {
            
            string fileName = "c#1000.txt";
            string text = System.IO.File.ReadAllText(fileName);
            var text1 = new Arrays(MakeTextIntoArray(text));


            fileName = "Computer programming1500.txt";
            text = System.IO.File.ReadAllText(fileName);
            var text2 = new Arrays(MakeTextIntoArray(text));

            fileName = "javascript3000.txt";
            text = System.IO.File.ReadAllText(fileName);
            var text3 = new Arrays(MakeTextIntoArray(text));

        }

        public static string[] MakeTextIntoArray(string text)
        {
            char[] separators = new char[] { ' ', '.', ',', '[', ']', '(', ')', '"', '*' };
            string[] textArray = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            return textArray;
        }
    }
}