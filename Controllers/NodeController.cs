using System;
using System.Diagnostics;
using WordSearcher.Model;
using WordSearcher.View;

namespace WordSearcher.Controllers
{
    class NodeController
    {
        public Node RootNode { get; set; }
        private Node currentNode;
        private int letterInWord;
        private int letterValue;
        private int comparisonLetterValue;
        public bool keepGoing = true;

        //Constructor
        public NodeController(Word word)
        {
            SetRootNode(word);
        }
        public NodeController()
        {
        }
        /// <summary>
        /// Sets node to rootNode if null and currentNode to rootNode
        /// </summary>
        /// <param name="word">The word to handle</param>
        public void SetRootNode(Word word)
        {
            if (RootNode == null)
            {
                RootNode = new Node(word);
                SetCurrentNodeToRootNode();
                NodeControllerView.SetRootNode();
                NodeControllerView.SetNode(word.WordValue);
            }
            else
            {
                SetCurrentNodeToRootNode();
                Stopwatch sw = new Stopwatch();
                sw.Start();
                SaveNodeToTree(word);
                sw.Stop();
                Console.WriteLine($"time elapsed: {sw.Elapsed}");
            }
        }
        /// <summary>
        /// Saves data in tree structure according to char value. Uses recursion.
        /// </summary>
        /// <param name="word">The word to add to list</param>
        //------Kommentar för VG -----
        //Denna metod använder sig av rekursion när den jämför bokstäver i ord, om de är samma eller inte.
        //Koden följer de tre principerna av rekursion:
        //1. Den har ett basfall där den kontrollerar om bokstäverna är lika eller ej.
        //2. Den ändrar sitt tillstånd, byter bokstav till nästa i orden (letterInWord++).
        //3. Den kallar på sig själv.
        //Denna löste vi med en loop först vilket visade sig vara lite, lite snabbare vid ett litet träd,
        //men valde att göra en ren rekursionsmetod istället för att gå snabbare vid stora mängder data.
        // Ordo = O(log n + 5)
        private void SaveNodeToTree(Word word)
        {
            //If the word is already in the tree, it should not be saved again.
            if (word.WordValue == currentNode.Word.WordValue && keepGoing)
            {
                NodeControllerView.SaveNodeToTree(word.WordValue.ToLower());
                keepGoing = false;
            }
            //Compares if first letter in word is same as currentNode first letter. If so, checks the next letter by recursion.
            //False if the letters to compare is not possible because of word length.
            if (letterInWord < word.WordValue.Length &&
            letterInWord < currentNode.Word.WordValue.Length &&
            word.WordValue[letterInWord] == currentNode.Word.WordValue[letterInWord] &&
            keepGoing)
            {
                letterInWord++;
                SaveNodeToTree(word);
            }
            //Transforms the letter to an int value
            else if (keepGoing)
            {
                if (letterInWord < word.WordValue.Length)
                    letterValue = FindLetterValue(word.WordValue[letterInWord]);
                if (letterInWord < currentNode.Word.WordValue.Length)
                    comparisonLetterValue = FindLetterValue(currentNode.Word.WordValue[letterInWord]);
            }
            if (keepGoing)
            {
                TryToSetLeftOrRightNode(word);
            }
            letterInWord = 0;
        }
        /// <summary>
        /// Tries to set the left or right node.
        /// </summary>
        /// <param name="word">the Word to set.</param>
        private void TryToSetLeftOrRightNode(Word word)
        {
            //compares if letter in word is BEFORE the letter in current node.
            if (letterValue < comparisonLetterValue)
            {
                TrySetLeftNode(word);
                keepGoing = false;
            }
            //Letter in word should be AFTER the letter in current node.
            else
            {
                TrySetRightNode(word);
                keepGoing = false;
            }
        }
        /// <summary>
        /// Checks if right node is available, if so, sets it to the node.
        /// </summary>
        /// <param name="word">The word to add to list</param>
        private void TrySetRightNode(Word word)
        {
            if (currentNode.RightNode == null)
            {
                currentNode.SetRightNode(new Node(word));
                NodeControllerView.SetNode(word.WordValue);
            }
            //if right node is not null, set current node to the right node and do all checks from SaveNodeToTree again.
            else
            {
                currentNode = currentNode.RightNode;
                letterInWord = 0;
                keepGoing = true;
                SaveNodeToTree(word);
            }
        }
        /// <summary>
        /// Checks if left node is available, if so, sets it to the node.
        /// </summary>
        /// <param name="word">The word to add to list</param>
        private void TrySetLeftNode(Word word)
        {
            if (currentNode.LeftNode == null)
            {
                currentNode.SetLeftNode(new Node(word));
                NodeControllerView.SetNode(word.WordValue);
            }
            //if left node is not null, set current node to the left node and do all checks from SaveNodeToTree again.
            else
            {
                currentNode = currentNode.LeftNode;
                letterInWord = 0;
                keepGoing = true;
                SaveNodeToTree(word);
            }
        }
        /// <summary>
        /// Converts a char to its int value.
        /// </summary>
        /// <param name="letter">The letter to convert.</param>
        /// <returns>A chars int value.</returns>
        private int FindLetterValue(char letter)
        {
            return (int)letter;
        }
        /// <summary>
        /// Displays all nodes in the node tree, starting from the far left of the root.
        /// </summary>
        /// <param name="node"></param>
        //------Kommentar för VG -----
        //Denna metod använder sig av rekursion när den söker sig ned i trädet och letar efter en null-node. För varje gång den inte träffar null,
        //kallas samma metod igen och anropet läggs på stacken. När null påträffas börjar den skriva ut det senaste anropet (längs upp i stacken), för att sedan beta av anrop efter anrop.
        //Detta gör att orden skrivs ut i bokstavsordning.
        //Koden följer de tre principerna av rekursion:
        //1. Den har ett basfall där den kontrollerar efter null.
        //2. Den ändrar sitt tillstånd, byter nod till en längre ned i trädet.
        //3. Den kallar på sig själv.
        //Detta hade gått att lösa med en loop också, men det hade antagligen tagit något längre tid vid stora mängder data. Vid lite data är det mycket liten skillnad. 
        private void DisplayNodes(Node node) //Starts with the root node
        {
            if (node == null)
            {
                return;
            }
            DisplayNodes(node.LeftNode); //Send the left node to this method until node has no left node. Recursion.
            Console.WriteLine(node);//Prints out node data.
            DisplayNodes(node.RightNode);//send right node to this method and repeats the same procedure with all left nodes. Recursion.
        }
        /// <summary>
        /// Displays all nodes in the node tree, starting from the far left of the root.
        /// </summary>
        public void DisplayNodes()
        {
            if (RootNode == null)
            {
                NodeControllerView.DisplayNodesFail();
            }
            else
            {
                DisplayNodes(RootNode);
            }
        }
        /// <summary>
        /// Sets the current node to the root node for comparison.
        /// </summary>
        private void SetCurrentNodeToRootNode()
        {
            if (RootNode != null)
            {
                currentNode = RootNode;
            }
        }
    }
}
