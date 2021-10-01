using System;
using System.Collections.Generic;
using System.Text;

namespace Day15BinarySearchTree
{
    class BinarySearchTree<T> where T: IComparable<T>
    {
        public T NodeData { get; set; }
        public BinarySearchTree<T> leftTree { get; set; }
        public BinarySearchTree<T> rightTree { get; set; }
        
        public BinarySearchTree(T NodeData)
        {
            this.NodeData = NodeData;
            this.rightTree = rightTree;
            this.leftTree = leftTree;
        }
        int leftCount = 0, rightCount = 0;
        bool result = false;
        public void Insert(T item)
        {
            T currentNodeValue = this.NodeData;
            if ((currentNodeValue.CompareTo(item)) < 0)
            {
                if (this.leftTree == null)
                    this.leftTree = new BinarySearchTree<T>(item);
                else
                    this.leftTree.Insert(item);
            }
            else
            {
                if (this.rightTree == null)
                    this.rightTree = new BinarySearchTree<T>(item);
                else
                    this.rightTree.Insert(item);
            }
        }
        public void Display()
        {
            if(this.leftTree!=null)
            {
                this.leftCount++;
                this.leftTree.Display();
            }
            Console.WriteLine(this.NodeData.ToString());
            if(this.rightTree!=null)
            {
                this.rightCount++;
                this.rightTree.Display();
            }
        }
        public void Getsize()
        {
            Console.WriteLine("Size of BST " + (1 + this.leftCount + this.rightCount));
        }
        public bool IfExists(T element, BinarySearchTree<T> node)
        {
            if (node == null)
                return false;
            if(node.NodeData.Equals(element))
            {
                Console.WriteLine("Found element"+node.NodeData);
                result = true;
            }
            else
                Console.WriteLine("current element is {0} in BST",node.NodeData);
            if (element.CompareTo(node.NodeData) < 0)
                IfExists(element, node.leftTree);
            if (element.CompareTo(node.NodeData) > 0)
                IfExists(element, node.rightTree);
            return result;
        }

    }
}
