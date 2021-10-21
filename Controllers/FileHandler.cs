using System;
using WordSearcher.Model;

namespace WordSearcher.Controller
{
    class FileHandler
    {
        /// <summary>
        /// l�ser in 3 textfiler och sparar dem i model Arrays
        /// </summary>
        public static void GetDataFromTexFile()
        {
            var fileName = "c#1000.txt";
            var text = System.IO.File.ReadAllText(fileName);
            var text1 = new Arrays(MakeTextIntoArray(text), fileName);
            AddTextArrayToList(text1);
            fileName = "Computer programming1500.txt";
            text = System.IO.File.ReadAllText(fileName);
            var text2 = new Arrays(MakeTextIntoArray(text), fileName);
            AddTextArrayToList(text2);
            fileName = "javascript3000.txt";
            text = System.IO.File.ReadAllText(fileName);
            var text3 = new Arrays(MakeTextIntoArray(text), fileName);
            AddTextArrayToList(text3);
        }

        public static string[] MakeTextIntoArray(string text)
        {
            var separators = new char[] { ' ', '.', ',', '[', ']', '(', ')', '"', '*' };
            return text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
        }
        private static void AddTextArrayToList(Arrays textArray)
        {
            Arrays.ArrayList.Add(textArray);
        }
    }
}