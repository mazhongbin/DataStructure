using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayDemo
{
    public class ArrayStack<T> : IStack<T>
    {
        private ArrayV1<T> array;

        public ArrayStack(int capacity)
        {
            array = new ArrayV1<T>(capacity);
        }

        public ArrayStack()
        {
            array = new ArrayV1<T>();
        }

        public int GetSize()
        {
            return array.GetSize();
        }

        public bool IsEmpty()
        {
            return array.IsEnpty();
        }

        public T Peek()
        {
            return array.GetLast();
        }

        public T Pop()
        {
            return array.RemoveLast();
        }

        public void Push(T e)
        {
            array.AddLast(e);
        }

        public override string ToString()
        {
            StringBuilder res = new StringBuilder();
            res.Append("Stack: ");
            res.Append("[");
            for (int i = 0; i < array.GetSize(); i++)
            {
                res.Append(array.Get(i));
                if (i != array.GetSize() - 1)
                    res.Append(",");
            }
            res.Append("] top");
            return res.ToString();
        }
    }
}
