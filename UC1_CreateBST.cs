using System;
using System.Collections.Generic;
using System.Text;

namespace Day15BinarySearchTree
{
    class UC1_CreateBST<T> where T : IComparable<T>
    {
        public T NodeData { get; set;}
        public UC1_CreateBST<T> lefttree { get; set; }
        public UC1_CreateBST<T> righttree { get; set; }

        public UC1_CreateBST(T NodeData)
        {
            this.NodeData = NodeData;
            this.righttree = righttree;
            this.lefttree = lefttree;
        }
        int leftcount = 0, rightcount=0;
        bool result = false;

        public void Insert(T item)
        {
            T currentNodeValue = this.NodeData;
            if ((currentNodeValue.CompareTo(item)) > 0)
            {
                if (this.lefttree == null)
                    this.lefttree = new UC1_CreateBST<T>(item);
                else
                    this.lefttree.Insert(item);
            }
            else
            {
                if (this.righttree == null)
                    this.righttree = new UC1_CreateBST<T>(item);
                else
                    this.righttree.Insert(item);
            }
        }
        public void Display()
        {
            if(this.lefttree!=null)
            {
                this.leftcount++;
                this.lefttree.Display();
            }
            Console.WriteLine(this.NodeData.ToString());
            if (this.righttree!=null)
            {
                this.rightcount++;
                this.righttree.Display();
            }
        }
        public void Getsize()
        {
            Console.WriteLine("Size of BST"+" "+(1+this.leftcount+this.rightcount));
        }
        public bool IfExists(T element, UC1_CreateBST<T> node)
        {
            if (node == null)
                return false;
            if (node.NodeData.Equals(element))
            {
                Console.WriteLine("Found element in BST "+node.NodeData);
                result =true;
            }
            else
                Console.WriteLine("Current Element is {0} in BST ",node.NodeData);
            if (element.CompareTo(node.NodeData) < 0)
                IfExists(element, node.lefttree);
            if (element.CompareTo(node.NodeData) > 0)
                IfExists(element, node.righttree);
            return result;
        }
    }
}

