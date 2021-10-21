using System;

namespace WordSearcher.View
{
    class NodeControllerView
    {
        public void OutputView()
        {
            //Console.WriteLine("");
        }

        internal static void SetRootNode()
        {
            Console.WriteLine("New root node set");
        }

        internal static void SaveNodeToTree(string wordValue)
        {
            Console.WriteLine($"\n\"{wordValue}\" is already in the list...");
        }

        internal static void SetNode(string wordValue)
        {
            Console.WriteLine($"\n\"{wordValue}\" is added to the node tree structure");
        }
    }
}
