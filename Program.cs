using System;

namespace Day15BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("******Welcome to Binary Serach Tree******");
            #region UC1
            UC1_CreateBST<int> BinarySearchtree = new UC1_CreateBST<int>(56);
            BinarySearchtree.Insert(30);
            BinarySearchtree.Insert(70);
            BinarySearchtree.Display();
            #endregion

            #region UC2
            BinarySearchTree<int> BinaryTree = new BinarySearchTree<int>(56);
            BinaryTree.Insert(30);
            BinaryTree.Insert(70);
            BinaryTree.Insert(22);
            BinaryTree.Insert(40);
            BinaryTree.Insert(60);
            BinaryTree.Insert(95);
            BinaryTree.Insert(11);
            BinaryTree.Insert(65);
            BinaryTree.Insert(3);
            BinaryTree.Insert(16);
            BinaryTree.Insert(63);
            BinaryTree.Insert(67);
            BinaryTree.Display();
            BinaryTree.Getsize();
            #endregion

            #region UC3
            UC3_Search63BST<int> Binarytree = new UC3_Search63BST<int>(56);
            Binarytree.Insert(30);
            Binarytree.Insert(70);
            Binarytree.Insert(22);
            Binarytree.Insert(40);
            Binarytree.Insert(60);
            Binarytree.Insert(95);
            Binarytree.Insert(11);
            Binarytree.Insert(65);
            Binarytree.Insert(3);
            Binarytree.Insert(16);
            Binarytree.Insert(63);
            Binarytree.Insert(67);
            Binarytree.Display();
            Binarytree.Getsize();
            bool result = Binarytree.IfExists(63, Binarytree);
            Console.WriteLine(result);
            #endregion
            Console.ReadKey();
        }
    }
}
