using System;

namespace WordSearcher.View
{
    class NodeControllerView
    {
        /// <summary>
        /// Outputs "New root node set"
        /// </summary>
        internal static void SetRootNode()
        {
            Console.WriteLine("New root node set");
        }
        /// <summary>
        /// Outputs "word is already in the list..."
        /// </summary>
        /// <param name="wordValue">The word which tries to be added to node tree.</param>
        internal static void SaveNodeToTree(string wordValue)
        {
            Console.WriteLine($"\n\"{wordValue}\" is already in the list...");
        }
        /// <summary>
        /// Outputs: "word is added to the node tree structure"
        /// </summary>
        /// <param name="wordValue">The word which tries to be added to node tree.</param>
        internal static void SetNode(string wordValue)
        {
            Console.WriteLine($"\n\"{wordValue}\" is added to the node tree structure");
        }

        /// <summary>
        /// Outputs: "Your tree of saved words is empty...".
        /// </summary>
        internal static void DisplayNodesFail()
        {
            Console.WriteLine("Your tree of saved words is empty...");
        }
        /// <summary>
        ///  Outputs: "word does NOT exist in the node tree."
        /// </summary>
        /// <param name="wordToSearch">The searched word</param>
        internal static void SearchWordInTreeFail(string wordToSearch)
        {
            Console.WriteLine($"{wordToSearch} does NOT exist in the node tree.");
        }
        /// <summary>
        ///  Outputs: "word does exist in the node tree."
        /// </summary>
        /// <param name="wordToSearch">The searched word</param>
        internal static void SearchWordInTree(string wordToSearch)
        {
            Console.WriteLine($"{wordToSearch} does exist in the node tree.");
        }
    }
}
