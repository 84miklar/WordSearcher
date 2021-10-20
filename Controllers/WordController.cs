using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordSearcher.Model;

namespace WordSearcher.Controllers
{
    public class WordController
    {

      static NodeController nc = new NodeController();
        internal static void SearchWord()
        {
            Console.WriteLine("Type the word you are intrested in: ");
            var searchedWord = Console.ReadLine();
            var newWord = new Word(searchedWord);
            AddWordToNodeList(newWord);
            Console.WriteLine(newWord);
        }

        private static void AddWordToNodeList(Word word)
        {
            nc.SetRootNode(word);
        }
        internal static void PrintWordsInTree()
        {
            nc.DisplayNodes();
        }
    }
}
