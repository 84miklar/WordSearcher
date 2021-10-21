﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordSearcher.Model;
using WordSearcher.View;

namespace WordSearcher.Controllers
{
    public class WordController
    {
        /// <summary>
        /// A new NodeController for the WordController class.
        /// </summary>
        static NodeController nc = new();
        /// <summary>
        /// Method that handles the search word input.
        /// </summary>
        internal static void SearchWord()
        {
            WordView.SearchedWord();
            var searchedWord = Console.ReadLine();
            if (searchedWord != null && searchedWord != "")
            {
                var newWord = new Word(searchedWord);
                AddWordToNodeList(newWord);
            }
            else
            {
                WordView.InvalidInput();
            }
        }
        /// <summary>
        /// Sends the new Word to the NodeController.
        /// </summary>
        /// <param name="word">The Word to add to Node tree</param>
        private static void AddWordToNodeList(Word word)
        {
            nc.SetRootNode(word);
        }
        /// <summary>
        /// Sends the user to DisplayNodes in NodeController.
        /// </summary>
        internal static void PrintWordsInTree()
        {
            nc.DisplayNodes();
        }
    }
}
