using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayDemo
{
    public class LinkedListQueue<T> : IQueue<T>
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

        private Node head, tail;
        private int size;

        public LinkedListQueue()
        {
            head = null;
            tail = null;
            size = 0;
        }


        public T Dequeue()
        {
            if (IsEmpty())
                throw new ArgumentOutOfRangeException("empty");
            Node res = head;
            head = head.next;
            res.next = null;
            if (head == null)
                tail = null;
            size--;
            return res.t;
        }

        public void Enqueue(T t)
        {
            if(tail==null)
            {
                tail = new Node(t);
                head = tail;
            }
            else
            {
                tail.next = new Node(t);
                tail = tail.next;
            }
            size++;
        }

        public T GetFront()
        {
            if (IsEmpty())
                throw new ArgumentOutOfRangeException("empty");
            return head.t;
        }

        public int GetSize()
        {
            return size;
        }

        public bool IsEmpty()
        {
            return size == 0;
        }

        public override string ToString()
        {
            StringBuilder res = new StringBuilder();
            res.Append("Queue: front ");
            Node cur = head;
            while (cur != null)
            {
                res.Append(cur + "->");
                cur = cur.next;
            }
            res.Append("Null tail");
            return res.ToString();
        }
    }
}
