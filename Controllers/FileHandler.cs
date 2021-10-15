using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordSearcher.Controller
{
    class FileHandler
    {
        public static void GetDataFromTexFile()
        {
            string text = System.IO.File.ReadAllText(@"..\..\WordSearcher\Recourses\Readtest.txt");
           
            System.Console.WriteLine("Contents of ReadTest.txt = {0}", text);
                

        }
    }
}
