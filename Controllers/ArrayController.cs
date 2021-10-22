using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordSearcher.Controllers
{
    static class ArrayController
    {
        public static int PrintChosenAmountOfWords()
        {
            Console.WriteLine("Enter number of words to print from each Array");
            var number = ControlHelper.TryParse();
            return number;
        }
    }
}
