using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordSearcher.View
{
    public class WordView
    {

        /// <summary>
        /// Outputs: "Type the word you are intrested in: "
        /// </summary>
        internal static void SearchedWord()
        {
            Console.WriteLine("Type the word you are intrested in: ");
        }
        /// <summary>
        /// Outputs: "Invalid input. Input must be at least one character long."
        /// </summary>
        internal static void InvalidInput()
        {
            Console.WriteLine("Invalid input. Input must be at least one character long.");
        }
        /// <summary>
        /// Outputs: Would you like to add "word" to the node tree structure? press "y" for yes or "n" for no."
        /// </summary>
        /// <param name="word">The searched word to add to node tree.</param>
        /// <returns>true if word should be saved to node tree</returns>
        internal static bool WouldYouLikeToAddToTree(string word)
        {
            Console.WriteLine($"Would you like to add \"{word}\" to the node tree structure?\n press \"y\" for yes or \"n\" for no.");
            var input = Console.ReadLine();
            return input.ToLower().Trim() == "y";
        }
        /// <summary>
        /// Outputs: ""word" is not added to the list."
        /// </summary>
        /// <param name="word">The searched word.</param>
        internal static void DoNotAddWordToTree(string word)
        {
            Console.WriteLine($"\"{word}\" is not added to the list.");
        }

        internal static string SearchWordInTree()
        {
            Console.WriteLine("Type a word and see if it´s in the tree of saved words:");
            return Console.ReadLine().Trim();
        }
    }
}
