using System;
using System.Collections.Generic;
using System.Text;

namespace BST
{
    class Node
    {
        public Node right;
        public Node left;
        public int num; //just a number could be anything else
        public Node(int num) { this.num = num; left = null; right = null; }
    }
}
