using System;
using System.Text;

namespace ArrayDemo
{
    public class ArrayV1<T>
    {
        /// <summary>
        /// ����
        /// </summary>
        private T[] data;

        /// <summary>
        /// ��С
        /// </summary>
        private int size;

        /// <summary>
        /// ���캯��
        /// </summary>
        /// <param name="capatity"></param>
        public ArrayV1(int capatity)
        {
            data = new T[capatity];
            size = 0;
        }

        /// <summary>
        /// ���캯��
        /// </summary>
        public ArrayV1() : this(10)
        {
        }

        /// <summary>
        /// ʵ�ʰ���Ԫ�صĸ���
        /// </summary>
        /// <returns></returns>
        public int GetSize()
        {
            return size;
        }

        /// <summary>
        /// ��ȡ�����С
        /// </summary>
        /// <returns></returns>
        public int GetCapacity()
        {
            return data.Length;
        }

        /// <summary>
        /// �Ƿ�Ϊ��
        /// </summary>
        /// <returns></returns>
        public Boolean IsEnpty()
        {
            return data.Length == 0;
        }

        public void AddLast(T e)
        {
            Add(size, e);
        }

        public void AddFirst(T e)
        {
            Add(0, e);
        }

        /// <summary>
        /// ���ض����������һ��Ԫ��
        /// </summary>
        /// <param name="index"></param>
        /// <param name="e"></param>
        public void Add(int index, T e)
        {
            if (index < 0 || index > size)
                throw new ArgumentOutOfRangeException("index is out of range");
            if (size == data.Length)
                Resize(2 * data.Length);
            for (int i = size - 1; i > index; i--)
                data[i + 1] = data[i];
            data[index] = e;
            size++;
        }

        /// <summary>
        /// ����Ϊԭ����2��
        /// </summary>
        /// <param name="v"></param>
        private void Resize(int capacity)
        {
            T[] newData = new T[capacity];
            for (int i = 0; i < size; i++)
                newData[i] = data[i];
            data = newData;
        }

        /// <summary>
        /// ��ȡĳ��Ԫ��
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public T Get(int index)
        {
            if (index < 0 || index >= size)
                throw new ArgumentOutOfRangeException("out of range");
            return data[index];
        }

        /// <summary>
        /// ��ȡ���һ��Ԫ��
        /// </summary>
        /// <returns></returns>
        public T GetLast()
        {
            return Get(size - 1);
        }

        /// <summary>
        /// ��ȡ��һ��Ԫ��
        /// </summary>
        /// <returns></returns>
        public T GetFirst()
        {
            return Get(0);
        }

        /// <summary>
        /// ����ĳ��Ԫ�ص�ֵ
        /// </summary>
        /// <param name="index"></param>
        /// <param name="e"></param>
        public void Set(int index, T e)
        {
            if (index < 0 || index >= size)
                throw new ArgumentOutOfRangeException("out of range");
            data[index] = e;
        }

        /// <summary>
        /// �������Ƿ����ĳ��Ԫ��
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public Boolean Contains(T e)
        {
            for (int i = 0; i < size; i++)
            {
                if (data[i].Equals(e))
                    return true;
            }
            return false;
        }

        /// <summary>
        /// ��������ڷ���-1�����򷵻�����
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public int Find(T e)
        {
            for (int i = 0; i < size; i++)
            {
                if (data[i].Equals(e))
                    return i;
            }
            return -1;
        }

        /// <summary>
        /// �Ƴ�ĳ��Ԫ��
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public T Remove(int index)
        {
            if (index < 0 || index >= size)
                throw new ArgumentOutOfRangeException("out of range");
            T ret = data[index];
            for (int i = index; i < size; i++)
            {
                data[i - 1] = data[i];
            }
            size--;
            data[size] = default(T);//loitering object
            if (size == data.Length / 4 && data.Length / 2 != 0)
                Resize(data.Length / 2);
            return ret;
        }

        /// <summary>
        /// �Ƴ���һ��Ԫ��
        /// </summary>
        /// <returns></returns>
        public T RemoveFirst()
        {
            return Remove(0);
        }

        /// <summary>
        /// �Ƴ����һ��Ԫ��
        /// </summary>
        /// <returns></returns>
        public T RemoveLast()
        {
            return Remove(size - 1);
        }

        /// <summary>
        /// ����о��Ƴ���Ԫ��
        /// </summary>
        /// <param name="e"></param>
        public void RemoveElement(T e)
        {
            int index = Find(e);
            if (index != -1)
                Remove(index);
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
