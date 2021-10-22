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
        /// Outputs ""wordValue" is already in the list...");
        /// </summary>
        /// <param name="wordValue">The word which tries to be added to node tree.</param>
        internal static void SaveNodeToTree(string wordValue)
        {
            Console.WriteLine($"\n\"{wordValue}\" is already in the list...");
        }
        /// <summary>
        /// Outputs ""wordValue" is added to the node tree structure");
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
    }
}
