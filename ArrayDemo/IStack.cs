using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayDemo
{
    public interface IStack<T>
    {
        int GetSize();
        Boolean IsEmpty();
        void Push(T e);
        T Pop();
        T Peek();
    }
}
