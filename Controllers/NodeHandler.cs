using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordSearcher.Model;

namespace WordSearcher.Controllers
{
    class NodeHandler
    {
        private Node rootNode;
        private Node currentNode;
        private int letterInWord = 0;
        private int letterValue = 0;

        //Constructor
        public NodeHandler(Node node)
        {
            SetRootNode(node);
            SaveData(node);
        }
        /// <summary>
        /// Sets node to rootNode if null and currentNode to rootNode
        /// </summary>
        /// <param name="node">The node to handle</param>
        public void SetRootNode(Node node)
        {
            if(rootNode == null)
            {
                rootNode = node;
            }
            currentNode = rootNode;
        }
        /// <summary>
        /// Saves data in structure according to char value.
        /// </summary>
        /// <param name="node">The node to add to list</param>
        public void SaveData(Node node)
        {
            if(node.Word.WordValue == currentNode.Word.WordValue)
            {
                Console.WriteLine("This word is already in the list...");
            }
            //Compares is first letter in word is same as currentNode first letter. If so, checks the next letter.
            if(node.Word.WordValue[letterInWord] == currentNode.Word.WordValue[letterInWord])
            {
                letterInWord++;
                SaveData(node);
            }
            //Transforms the letter to an int value
            else
            {
               letterValue = FindLetterValue(node.Word.WordValue[letterInWord]);
            }
            //compares if letter in word is BEFORE the letter in current node.
            if(letterValue < FindLetterValue(currentNode.Word.WordValue[letterInWord]))
            {
                TrySetLeftNode(node);
            }
            //compares if letter in word is AFTER the letter in current node.
            if (letterValue > FindLetterValue(currentNode.Word.WordValue[letterInWord]))
            {
                TrySetRightNode(node);
            }
        }
        /// <summary>
        /// Checks if right node is available, else sets it to the node.
        /// </summary>
        /// <param name="node">The node to add to list</param>
        private void TrySetRightNode(Node node)
        {
            if (currentNode.RightNode == null)
            {
                currentNode.RightNode = node;
            }
            //if left node is not null, set current node to the left node and do all checks again.
            else
            {
                currentNode = currentNode.RightNode;
                SaveData(node);
            }
        }
        /// <summary>
        /// Checks if left node is available, else sets it to the node.
        /// </summary>
        /// <param name="node">The node to add to list</param>
        private void TrySetLeftNode(Node node)
        {
            if (currentNode.LeftNode == null)
            {
                currentNode.LeftNode = node;
            }
            //if left node is not null, set current node to the left node and do all checks again.
            else
            {
                currentNode = currentNode.LeftNode;
                SaveData(node);
            }
        }

        private int FindLetterValue(char letter)
        {
            return (int)letter;
        }

        public void SearchData()
        {

        }
        public void OutputData()
        {
            //En loop som hämtar data och skickar till view.
        }
    }
}
