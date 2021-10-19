using System;
using WordSearcher.Model;

namespace WordSearcher.Controller
{
     class FileHandler
    {
        public static void GetDataFromTexFile()
        {
            /*
            string fileName = "TestTextFile1.txt";
            string text = System.IO.File.ReadAllText(fileName);
            Arrays.SetTestArray(MakeTextIntoArray(text));

            
                  
            
            MakeTextIntoArray(text);
            //MakeTextIntoArray(text);            

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