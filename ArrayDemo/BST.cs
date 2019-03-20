using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayDemo
{
    public class BST<E> where E : IComparable
    {
        /// <summary>
        /// 节点类，私有
        /// </summary>
        private class Node
        {
            public E e;
            public Node left, right;

            public Node(E e)
            {
                this.e = e;
                left = null;
                right = null;
            }
        }

        private Node root;
        private int size;
        public BST()
        {
            root = null;
            size = 0;
        }

        public int Size()
        {
            return size;
        }

        public bool IsEmpty()
        {
            return size == 0;
        }

        public void Add(E e)
        {

            root = Add(root, e);
        }

        private Node Add(Node node, E e)
        {
            //if (e.Equals(node.e))
            //    return;
            //else if (e.CompareTo(node.e) < 0 && node.left == null)
            //{
            //    node.left = new Node(e);
            //    size++;
            //    return;
            //}
            //else if (e.CompareTo(node.e) > 0 && node.right == null)
            //{
            //    node.right = new Node(e);
            //    size++;
            //    return;
            //}
            //if (e.CompareTo(node.e) < 0)
            //    Add(node.left, e);
            //else
            //    Add(node.right, e);

            if (node == null)
            {
                size++;
                return new Node(e);
            }
            if (e.CompareTo(node.e) < 0)
                node.left = Add(node.left, e);
            else if (e.CompareTo(node.e) > 0)
                node.right = Add(node.right, e);
            return node;

        }
    }
}
