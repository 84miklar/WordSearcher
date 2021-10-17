using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordSearcher.Controller
{
    class FileHandler
    {
        public static void GetDataFromTexFile()
        {


            // var path = Path.Combine(Directory.GetCurrentDirectory(), "/Readtest.txt");
            //Console.WriteLine(path.ToString());
            string fileName = "Readtest.txt";
            string path1 = @"Controllers";
            string path2 = @"\Controllers";
            string fullPath;

            fullPath = Path.GetFullPath(path1);
            Console.WriteLine("GetFullPath('{0}') returns '{1}'",
                path1, fullPath);

            //fullPath = Path.GetFullPath(fileName);
            //Console.WriteLine("GetFullPath('{0}') returns '{1}'",
            //fileName, fullPath);

            //fullPath = Path.GetFullPath(path2);
            //Console.WriteLine("GetFullPath('{0}') returns '{1}'",
            //    path2, fullPath);
            //Path.GetDirectoryName

            string text = System.IO.File.ReadAllText(fullPath +"/Readtest.txt");
            //C:\Users\svanths\Source\Repos\84miklar\WordSearcher\Controllers\Readtest.txt

            System.Console.WriteLine("Contents of ReadTest.txt = {0}", text);

            
        }
    }
}
