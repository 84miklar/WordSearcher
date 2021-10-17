using System;
using System.Collections.Generic;
using System.IO;

using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace WordSearcher.Controller
{
    class FileHandler
    {
        public static void GetDataFromTexFile()
        {

                       
            string fileName = "TestTextFile1.txt";
            string path1 = @"Controllers";
            string path2 = @"\Controllers";
            string fullPath;

            //fullPath = Path.GetFullPath(path1);
            //Console.WriteLine("GetFullPath('{0}') returns '{1}'",
            //    path1, fullPath);


            fullPath = Path.GetFullPath(fileName);
            Console.WriteLine("GetFullPath('{0}') returns '{1}'",
            fileName, fullPath);

            //fullPath = Path.GetFullPath(path2);
            //Console.WriteLine("GetFullPath('{0}') returns '{1}'",
            //    path2, fullPath);
            //Path.GetDirectoryName
             var livet = Path.Combine(Directory.GetCurrentDirectory(), "fileName.txt");

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

            string text = System.IO.File.ReadAllText(life);
            //string text = System.IO.File.ReadAllText(fullPath);
            //string text = System.IO.File.ReadAllText(fullPath +"/Readtest.txt");
            //C:\Users\svanths\Source\Repos\84miklar\WordSearcher\Controllers\Readtest.txt



            System.Console.WriteLine("Contents of ReadTest.txt = {0}", text);

            
        }
    }
}
