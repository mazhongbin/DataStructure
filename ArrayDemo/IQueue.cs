using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayDemo
{
    public interface IQueue<T>
    {
        int GetSize();
        bool IsEmpty();
        void Enqueue(T t);
        T Dequeue();

        T GetFront();
    }
}
