using System;
using System.IO;

namespace BST
{
    class Program
    {
        
        static void Main(string[] args)
        {
            try
            {
                string[] file_A = File.ReadAllLines(@"C:\Users\Hybr1\OneDrive\Desktop\Textfilesforassignmet\assignment 3\file1.txt");
                BST list = new BST();
                foreach (string line in file_A)
                {
                    Node p = new Node(Convert.ToInt32(line));
                    BST bst = new BST();
                    bst.insert(p);
                    list.insert(p);
                }
                Console.WriteLine("\r\nLevel by level");
                list.levelPrint(list.root);
                Console.Write("Prime numbers are: ");
                list.testPrime(list.root);





                string[] file_B = File.ReadAllLines(@"C:\Users\Hybr1\OneDrive\Desktop\Textfilesforassignmet\assignment 3\file2.txt");
                BST list1 = new BST();
                foreach (string line in file_B)
                {
                    Node p = new Node(Convert.ToInt32(line));
                    BST bst = new BST();
                    bst.insert(p);
                    list1.insert(p);
                }
                Console.WriteLine("\r\nLevel by level");
                list1.levelPrint(list1.root);
                Console.Write("Prime numbers are: ");
                list1.testPrime(list1.root);



                string[] file_C = File.ReadAllLines(@"C:\Users\Hybr1\OneDrive\Desktop\Textfilesforassignmet\assignment 3\file3.txt");
                BST list3 = new BST();
                foreach (string line in file_C)
                {
                    Node p = new Node(Convert.ToInt32(line));
                    BST bst = new BST();
                    bst.insert(p);
                    list3.insert(p);
                }
                Console.WriteLine("\r\nLevel by level");
                list3.levelPrint(list3.root);
                Console.Write("Prime numbers are: ");
                list3.testPrime(list3.root);
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter only numeric values");
            }
            catch (FileNotFoundException) //Currently Throwing error in visual studios before reaching this
            {
                Console.WriteLine("Please check file paths of files");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Please make sure the files are within 32 bit limits");
            }
            catch
            {
                Console.WriteLine("An unideified error has occured");
            }
        }
    }
}
