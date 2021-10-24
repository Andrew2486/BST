using System;

namespace BST
{
    class BST
    {
        public Node root;
        public BST() { root = null; }
        public Node insert(Node p)
        {
                Node temp = root;
                if (temp == null)
                {
                    root = p;
                    return (root);
                }
                while (true)
                {
                    if (p.num < temp.num) //going left
                    {
                        if (temp.left == null)
                        {
                            temp.left = p;
                            break;
                        }
                        temp = temp.left;
                    }
                    else //going right
                    {
                        if (temp.right == null)
                        {
                            temp.right = p;
                            break;
                        }
                        temp = temp.right;
                    }
                }         
            //end of loop
            return (root); //returns the root
        }
        public void levelPrint(Node root) // removed Queue method (InOrder traversal (Left Root Right))
        {                       
            Node Parent = root;
            Console.WriteLine(root.num);
            while(root != null)
            {
                if (root.left != null)
                {
                    root = root.left; // Traverse left subtree
                    if (root != root.left)
                    { levelPrint(root); }
                }
                root = Parent; // visit root
                if (root.right != null)
                {
                    root = root.right; // Traverse right subtree
                    if (root != root.right)
                    { levelPrint(root); }
                }
                break;
            }
        }
        public void testPrime(Node root)
        {
            int m = 0;
            while (root != null)
            {
                int j = 0;
                if (root.left != null)
                {
                    testPrime(root.left);
                }
                if (root.right != null)
                {
                    testPrime(root.right);
                }
                if (root.num < 2)
                {
                    root.num = 4; // Easy method to remove anyhting < 2
                }
                m = root.num / 2;
                for (int i = 2; i <= m; i++)
                {
                    if (root.num % i == 0)
                    {
                        j = 1; // False
                        break;
                    }
                }
                if (j == 0) // True
                {
                    Console.Write(root.num + ", ");
                }
                break;
            }
        }
    }
}
