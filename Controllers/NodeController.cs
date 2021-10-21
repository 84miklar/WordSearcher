﻿using System;
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
        private bool keepGoing = true;

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
            }
            else
            {
                SetCurrentNodeToRootNode();
                SaveData(word);
            }
        }
        /// <summary>
        /// Method to call when a new word should be saved in node tree.
        /// </summary>
        /// <param name="word">The word to save in list.</param>
        public void SaveData(Word word)
        {
            SetCurrentNodeToRootNode();
            SaveNodeToTree(word);
        }
        /// <summary>
        /// Saves data in tree structure according to char value.
        /// </summary>
        /// <param name="word">The word to add to list</param>
        private void SaveNodeToTree(Word word)
        {
            keepGoing = true;
            while (keepGoing)
            {
                //If the word i already in the tree, it should not be saved again.
                if (word.WordValue == currentNode.Word.WordValue)
                {
                    NodeControllerView.SaveNodeToTree(word.WordValue.ToLower());
                    keepGoing = false;
                    break;
                }
                //Compares if first letter in word is same as currentNode first letter. If so, checks the next letter by recursion.
                if (word.WordValue[letterInWord] == currentNode.Word.WordValue[letterInWord])
                {
                    if (letterInWord < currentNode.Word.WordValue.Length)
                    {
                        letterInWord++;
                        SaveNodeToTree(word);
                        break;
                    }
                }
                //Transforms the letter to an int value
                else
                {
                    letterValue = FindLetterValue(word.WordValue[letterInWord]);
                    comparisonLetterValue = FindLetterValue(currentNode.Word.WordValue[letterInWord]);
                }
                //compares if letter in word is BEFORE the letter in current node.
                if (letterValue < comparisonLetterValue)
                {
                    TrySetLeftNode(word);
                    keepGoing = false;
                    break;
                }
                //Letter in word should be AFTER the letter in current node.
                else
                {
                    TrySetRightNode(word);
                    keepGoing = false;
                    break;
                }
            }
            letterInWord = 0;
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
            DisplayNodes(RootNode);
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
