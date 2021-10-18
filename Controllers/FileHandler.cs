using System;

namespace WordSearcher.Controller
{
     class FileHandler
    {
        public static void GetDataFromTexFile()
        {
            string fileName = "TestTextFile1.txt";
            string text = System.IO.File.ReadAllText(fileName);
            Model.Arrays.SetTestArray(MakeTextIntoArray(text));
            //MakeTextIntoArray(text);
            foreach (var item in collection)
            {

            }

            //fileName = "c#1000.txt";
            //text = System.IO.File.ReadAllText(fileName);
            //MakeTextIntoArray(text);

            //fileName = "Computer programming1500.txt";
            //text = System.IO.File.ReadAllText(fileName);
            //MakeTextIntoArray(text);

            //fileName = "javascript3000.txt";
            //text = System.IO.File.ReadAllText(fileName);
            //MakeTextIntoArray(text);

        }

        public static string[] MakeTextIntoArray(string text)
        {
            char[] separators = new char[] { ' ', '.', ',' };
            string[] textArray = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            return textArray;
        }
    }
}