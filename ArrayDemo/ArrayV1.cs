using System;
using System.Text;

namespace ArrayDemo
{
    public class ArrayV1
    {
        /// <summary>
        /// 数组
        /// </summary>
        private int[] data;

        /// <summary>
        /// 大小
        /// </summary>
        private int size;

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="capatity"></param>
        public ArrayV1(int capatity)
        {
            data = new int[capatity];
            size = 0;
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        public ArrayV1() : this(10)
        {
        }

        /// <summary>
        /// 实际包含元素的个数
        /// </summary>
        /// <returns></returns>
        public int GetSize()
        {
            return size;
        }

        /// <summary>
        /// 获取数组大小
        /// </summary>
        /// <returns></returns>
        public int GetCapacity()
        {
            return data.Length;
        }

        /// <summary>
        /// 是否为空
        /// </summary>
        /// <returns></returns>
        public Boolean IsEnpty()
        {
            return data.Length == 0;
        }

        public void AddLast(int e)
        {
            Add(size, e);
        }

        public void AddFirst(int e)
        {
            Add(0, e);
        }

        /// <summary>
        /// 在特定的索引添加一个元素
        /// </summary>
        /// <param name="index"></param>
        /// <param name="e"></param>
        public void Add(int index, int e)
        {
            if (size == data.Length)
                throw new ArgumentOutOfRangeException("add failure, array is full");
            if (index < 0 || index > size)
                throw new ArgumentOutOfRangeException("index is out of range");
            for (int i = size - 1; i > index; i--)
                data[i + 1] = data[i];
            data[index] = e;
            size++;
        }

        /// <summary>
        /// 获取某个元素
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public int Get(int index)
        {
            if (index < 0 || index >= size)
                throw new ArgumentOutOfRangeException("out of range");
            return data[index];
        }

        /// <summary>
        /// 设置某个元素的值
        /// </summary>
        /// <param name="index"></param>
        /// <param name="e"></param>
        public void Set(int index,int e)
        {
            if (index < 0 || index >= size)
                throw new ArgumentOutOfRangeException("out of range");
            data[index] = e;
        }

        /// <summary>
        /// 数组中是否包含某个元素
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public Boolean Contains(int e)
        {
            for (int i = 0; i < size; i++)
            {
                if (data[i] == e)
                    return true;
            }
            return false;
        }

        /// <summary>
        /// 如果不存在返回-1，否则返回索引
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public int Find(int e)
        {
            for (int i = 0; i < size; i++)
            {
                if (data[i] == e)
                    return i;
            }
            return -1;
        }


        public override string ToString()
        {
            StringBuilder res = new StringBuilder();
            res.Append($"Array size: {size}, Capacity: {data.Length}\n\r");
            res.Append("[");
            for (int i = 0; i < size; i++)
            {
                res.Append(data[i]);
                if (i != size - 1)
                    res.Append(", ");
            }
            res.Append("]");
            return res.ToString();
        }
    }
}
