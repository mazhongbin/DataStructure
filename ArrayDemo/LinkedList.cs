using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ArrayDemo
{
    public class LinkedList<T>
    {
        private class Node
        {
            public T t;
            public Node next;
            public Node(T t, Node next)
            {
                this.t = t;
                this.next = next;
            }
            public Node(T t) : this(t, null)
            {
            }

            public Node() : this(default(T), null)
            {
            }

            public override string ToString()
            {
                return t.ToString();
            }

        }

        private Node dummyHead;
        private int size;
        public LinkedList()
        {
            dummyHead = new Node(default(T), null);
            size = 0;
        }

        public int GetSize()
        {
            return size;
        }

        public bool IsEmpty()
        {
            return size == 0;
        }

        /// <summary>
        /// 往链表头添加一个节点
        /// </summary>
        /// <param name="t"></param>
        public void AddFirst(T t)
        {
            Add(0, t);
        }

        public void Add(int index, T t)
        {
            if (index < 0 || index > size)
                throw new ArgumentOutOfRangeException("out of range");
            Node prev = dummyHead;
            for (int i = 0; i < index; i++)
                prev = prev.next;
            //Node node = new Node(t);
            //node.next = prev.next;
            //prev.next = node;
            prev.next = new Node(t, prev.next);
            size++;
        }

        public void AddLast(T t)
        {
            Add(size, t);
        }

        public T Get(int index)
        {
            if (index < 0 || index > size)
                throw new ArgumentOutOfRangeException("out of range");
            Node cur = dummyHead.next;
            for (int i = 0; i < index; i++)
                cur = cur.next;
            return cur.t;
        }

        public T GetFirst()
        {
            return Get(0);
        }

        public T GetLast()
        {
            return Get(size);
        }

        public void Set(int index, T t)
        {
            if (index < 0 || index > size)
                throw new ArgumentOutOfRangeException("out of range");
            Node cur = dummyHead.next;
            for (int i = 0; i < index; i++)
                cur = cur.next;
            cur.t = t;
        }

        public bool Contains(T t)
        {
            Node cur = dummyHead.next;
            while (cur != null)
            {
                if (cur.t.Equals(t))
                    return true;
                cur = cur.next;
            }
            return false;
        }

        public T Remove(int index)
        {
            if (index < 0 || index > size)
                throw new ArgumentOutOfRangeException("out of range");
            Node prev = dummyHead;
            for (int i = 0; i < index; i++)
                prev = prev.next;
            Node retNode = prev.next;
            prev.next = retNode.next;
            retNode.next = null;
            size--;
            return retNode.t;
        }

        public T RemoveFirst()
        {
            return Remove(0);
        }

        public T RemoveLast()
        {
            return Remove(size - 1);
        }


        public override string ToString()
        {
            StringBuilder res = new StringBuilder();
            Node cur = dummyHead.next;
            while (cur!=null)
            {

                res.Append(cur + "->");
                cur = cur.next;
            }
            res.Append("Null");
            return res.ToString();
        }

    }
}
