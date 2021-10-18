using System;
using System.IO;

namespace WordSearcher.Controller
{
    internal class FileHandler
    {
        public static void GetDataFromTexFile()
        {
            string fileName = "TestTextFile1.txt";
            string fullPath;

            fullPath = Path.GetFullPath(fileName);
            Console.WriteLine("GetFullPath('{0}') returns '{1}'",
            fileName, fullPath);
            

            var life = Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "TestTextFile1.txt");
            try
            {
                // Open the text file using a stream reader.
                using (var sr = new StreamReader("TestTextFile1.txt"))
                {
                    // Read the stream as a string, and write the string to the console.
                    Console.WriteLine(sr.ReadToEnd());
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }

            string text = System.IO.File.ReadAllText(fileName);
            //string text = System.IO.File.ReadAllText(fullPath);
            //string text = System.IO.File.ReadAllText(fullPath +"/Readtest.txt");
            //C:\Users\svanths\Source\Repos\84miklar\WordSearcher\Controllers\Readtest.txt

            System.Console.WriteLine("Contents of ReadTest.txt = {0}", text);
            MakeTextIntoArray(text);

        }
        public static void MakeTextIntoArray(string text)
        {
            char[] separators = new char[] { ' ', '.', ',' };
            string[] textArray = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            foreach(string word in textArray)
            {
                Console.WriteLine(word);
            }


        }
    }
}