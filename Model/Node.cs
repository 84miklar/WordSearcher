using System;
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
        public Node GetLeftNode()
        {
            return this.LeftNode;
        }
        public Node GetRightNode()
        {
            return this.RightNode;
        }
        public Node SetLeftNode(Node newNode)
        {
            return this.LeftNode = newNode;
        }
        public Node SetRightNode(Node newNode)
        {
            return this.RightNode = newNode;
        }
        public override string ToString()
        {
            var display = $"{Word} \nLeft node: {LeftNode?.Word?.WordValue} \nRight node: {RightNode?.Word?.WordValue}";
            return display;
        }
    }
}
