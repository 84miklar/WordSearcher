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
            string text = System.IO.File.ReadAllText("/Readtest.txt");
           
            System.Console.WriteLine("Contents of ReadTest.txt = {0}", text);

            
        }
    }
}
