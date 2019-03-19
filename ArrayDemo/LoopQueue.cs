using System;
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

        public LoopQueue() : this(10)
        {
        }

        public int GetCapacity()
        {
            return data.Length - 1;
        }

        public T Dequeue()
        {
            if (IsEmpty())
            {
                throw new ArgumentOutOfRangeException("Empty");
            }
            T ret = data[front];
            data[front] = default(T);
            front++;
            size--;
            if (size == GetCapacity() / 4 && GetCapacity() != 0)
                Resize(GetCapacity() / 2);
            return ret;
        }

        public void Enqueue(T t)
        {
            if ((tail + 1) % data.Length == front)
            {
                Resize(GetCapacity() + 1);
            }
            data[tail] = t;
            tail = (tail + 1) % data.Length;
            size++;
        }

        private void Resize(int newCapacity)
        {
            T[] newData = new T[newCapacity + 1];
            for (int i = 0; i < size; i++)
            {
                newData[i] = data[(i + front) % data.Length];
            }
            data = newData;
            front = 0;
            tail = size;
        }

        public T GetFront()
        {
            if (IsEmpty())
            {
                throw new ArgumentOutOfRangeException("Empty");
            }
            return data[front];
        }

        public int GetSize()
        {
            return size;
        }

        public bool IsEmpty()
        {
            return front == tail;
        }

        public override string ToString()
        {
            StringBuilder res = new StringBuilder();
            res.Append("LoopQueue: ");
            res.Append("front [");
            for (int i = front; i != tail; i = (i + 1) % data.Length)
            {
                res.Append(data[i]);
                if ((i + 1) % data.Length != tail)
                    res.Append(",");
            }
            res.Append("] tail");
            return res.ToString();
        }
    }
}
