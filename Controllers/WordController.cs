using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordSearcher.Model;

namespace WordSearcher.Controllers
{
    public static class WordController
    {
        internal static void SearchWord()
        {
            Console.WriteLine("Type the word you are intrested in: ");
            var searchedWord = Console.ReadLine();
            var newWord = new Word(searchedWord);
            
        }

    }
}
