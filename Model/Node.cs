using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordSearcher.Model
{
    class Node
    {
        public Word Word { get; set; }
        public Node RightNode { get; set; }
        public Node LeftNode { get; set; }
        public Node(Word word)
        {
            Word = word;
        }
        /// <summary>
        /// Gets the left node from the current node.
        /// </summary>
        /// <returns>The left node or null</returns>
        public Node GetLeftNode()
        {
            return this.LeftNode;
        }
        /// <summary>
        /// Gets the right node from the current node.
        /// </summary>
        /// <returns>The right node or null</returns>
        public Node GetRightNode()
        {
            return this.RightNode;
        }
        /// <summary>
        /// Sets the left node.
        /// </summary>
        /// <param name="newNode"></param>
        /// <returns></returns>
        public Node SetLeftNode(Node newNode)
        {
            return this.LeftNode = newNode;
        }
        /// <summary>
        /// Sets the right node.
        /// </summary>
        /// <param name="newNode"></param>
        /// <returns></returns>
        public Node SetRightNode(Node newNode)
        {
            return this.RightNode = newNode;
        }
        public override string ToString()
        {
            var display = $"{Word} \nLeft node: \n\t{LeftNode?.Word?.WordValue.ToLower()} \nRight node: \n\t{RightNode?.Word?.WordValue.ToLower()}";
            return display;
        }
    }
}
