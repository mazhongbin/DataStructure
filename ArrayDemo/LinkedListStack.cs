using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayDemo
{
    public class LinkedListStack<T> : IStack<T>
    {
        private LinkedList<T> linkList;

        public LinkedListStack()
        {
            linkList = new LinkedList<T>();
        }

        public int GetSize()
        {
            return linkList.GetSize();
        }

        public bool IsEmpty()
        {
            return linkList.IsEmpty();
        }

        public T Peek()
        {
            return linkList.GetFirst();
        }

        public T Pop()
        {
            return linkList.RemoveFirst();
        }

        public void Push(T e)
        {
            linkList.AddFirst(e);
        }

        public override string ToString()
        {
            StringBuilder res = new StringBuilder();
            res.Append("Stack: top ");
            res.Append(linkList);
            return res.ToString();
        }
    }
}
