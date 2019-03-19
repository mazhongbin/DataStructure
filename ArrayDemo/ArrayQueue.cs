using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayDemo
{
    public class ArrayQueue<T> : IQueue<T>
    {
        private ArrayV1<T> array;

        public ArrayQueue()
        {
            array = new ArrayV1<T>(20);
        }

        public ArrayQueue(int capacity)
        {
            array = new ArrayV1<T>(capacity);
        }

        public T Dequeue()
        {
            return array.RemoveFirst();
        }

        public void Enqueue(T e)
        {
            array.AddLast(e);
        }

        public T GetFront()
        {
            return array.GetFirst();
        }

        public int GetSize()
        {
            return array.GetSize();
        }

        public bool IsEmpty()
        {
            return array.IsEmpty();
        }

        public int GetCapacity()
        {
            return array.GetCapacity();
        }

        public override string ToString()
        {
            StringBuilder res = new StringBuilder();
            res.Append("Queue: ");
            res.Append("front [");
            for (int i = 0; i < array.GetSize(); i++)
            {
                res.Append(array.Get(i));
                if (i != array.GetSize() - 1)
                    res.Append(",");
            }
            res.Append("] tail");
            return res.ToString();
        }
    }
}
