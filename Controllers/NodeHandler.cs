using System;
using WordSearcher.Model;
using WordSearcher.View;

namespace WordSearcher.Controllers
{
    class NodeHandler
    {
        public Node rootNode { get; set; }
        private Node currentNode;
        private int letterInWord = 0;
        private int letterValue = 0;
        private bool keepGoing = true;

        //Constructor
        public NodeHandler(Word word)
        {
            SetRootNode(word);

        }
        /// <summary>
        /// Sets node to rootNode if null and currentNode to rootNode
        /// </summary>
        /// <param name="word">The word to handle</param>
        private void SetRootNode(Word word)
        {
            if (rootNode == null)
            {
                rootNode = new Node(word);
                currentNode = rootNode;
                Console.WriteLine("New root node set");
            }
            else
            {
                currentNode = rootNode;
                SaveData(word);
            }
        }
        public void SaveData(Word word)
        {
            SetCurrentNodeToRootNode();
            SaveNodeToTree(word);
        }
        /// <summary>
        /// Saves data in structure according to char value.
        /// </summary>
        /// <param name="word">The word to add to list</param>
        private void SaveNodeToTree(Word word)
        {
            while (true)
            {
                if (word.WordValue == currentNode.Word.WordValue)
                {
                    Console.WriteLine("This word is already in the list...");
                    keepGoing = false;
                    break;
                }
                //Compares is first letter in word is same as currentNode first letter. If so, checks the next letter.
                if (word.WordValue[letterInWord] == currentNode.Word.WordValue[letterInWord])
                {
                    if (letterInWord < currentNode.Word.WordValue.Length)
                    {
                        letterInWord++;
                        SaveNodeToTree(word);
                    }
                }
                //Transforms the letter to an int value
                else
                {
                    letterValue = FindLetterValue(word.WordValue[letterInWord]);
                }
                //compares if letter in word is BEFORE the letter in current node.
                if (letterValue < FindLetterValue(currentNode.Word.WordValue[letterInWord]))
                {
                    TrySetLeftNode(word);
                    keepGoing = false;
                    break;
                }
                //compares if letter in word is AFTER the letter in current node.
                if (letterValue > FindLetterValue(currentNode.Word.WordValue[letterInWord]))
                {
                    TrySetRightNode(word);
                    keepGoing = false;
                    break;
                }
            }
        }
        /// <summary>
        /// Checks if right node is available, else sets it to the node.
        /// </summary>
        /// <param name="word">The word to add to list</param>
        private void TrySetRightNode(Word word)
        {
            if (currentNode.RightNode == null)
            {
                currentNode.SetRightNode(new Node(word));
            }
            //if left node is not null, set current node to the left node and do all checks again.
            else
            {
                currentNode = currentNode.RightNode;
                SaveNodeToTree(word);
            }

        }
        /// <summary>
        /// Checks if left node is available, else sets it to the node.
        /// </summary>
        /// <param name="word">The word to add to list</param>
        private void TrySetLeftNode(Word word)
        {
            if (currentNode.LeftNode == null)
            {
                currentNode.SetLeftNode(new Node(word));
            }
            //if left node is not null, set current node to the left node and do all checks again.
            else
            {
                currentNode = currentNode.LeftNode;
                SaveNodeToTree(word);
            }
            keepGoing = false;
        }

        /// <summary>
        /// Converts a char to its int value.
        /// </summary>
        /// <param name="letter">The letter to convert.</param>
        /// <returns></returns>
        private int FindLetterValue(char letter)
        {
            return (int)letter;
        }

        public void SearchData()
        {

        }
        /// <summary>
        /// Displays all nodes in the node tree, starting from the far left of the root.
        /// </summary>
        /// <param name="node"></param>
        private void DisplayNodes(Node node) //Starts with the root node
        {
            if (node == null)
            {
                return;
            }
            DisplayNodes(node.LeftNode); //Send the left node to this method until node has no left node.
            Console.WriteLine(node);//Prints out node data. 
            DisplayNodes(node.RightNode);//send right node to this method and repeats the same procedure with all left nodes. 
        }
        /// <summary>
        /// Displays all nodes in the node tree, starting from the far left of the root.
        /// </summary>
        public void DisplayNodes()
        {
            DisplayNodes(rootNode);
        }
        /// <summary>
        /// Sets the current node to the root node for comparison.
        /// </summary>
        private void SetCurrentNodeToRootNode()
            {
                if (rootNode != null)
                {
                    currentNode = rootNode;
                }
            }
        }
    }
