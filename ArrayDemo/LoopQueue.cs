using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayDemo
{
    public class LoopQueue<T> : IQueue<T>
    {
        private T[] data;
        private int front, tail;
        private int size;

        public LoopQueue(int capacity)
        {
            data = new T[capacity + 1];
            front = 0;
            tail = 0;
            size = 0;
        }

        public LoopQueue():this(10)
        {
        }

        public int GetCapacity()
        {
            return data.Length - 1;
        }

        public T Dequeue()
        {
            throw new NotImplementedException();
        }

        public void Enqueue(T t)
        {
            if ((tail + 1) % data.Length == front)
            {
                Resize(GetCapacity() + 1);
            }
        }

        private void Resize(int newCapacity)
        {
            T[] newData = new T[newCapacity + 1];
            for (int i = 0; i < size; i++)
            {
                newData[i] = data[(i + front) % data.Length];
            }
        }

        public T GetFront()
        {
            throw new NotImplementedException();
        }

        public int GetSize()
        {
            throw new NotImplementedException();
        }

        public bool IsEmpty()
        {
            throw new NotImplementedException();
        }
    }
}
