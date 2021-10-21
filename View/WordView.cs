using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordSearcher.View
{
    public class WordView
    {
        internal static void SearchedWord()
        {
            Console.WriteLine("Type the word you are intrested in: ");
        }

        internal static void InvalidInput()
        {
            Console.WriteLine("Invalid input. Input must be at least one character long.");
        }
    }
}
