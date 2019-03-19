using System;

namespace ArrayDemo
{
    class Program
    {
        static void Main(string[] args)
        {


            #region Basic Test
            ArrayV1<int> arrayV1 = new ArrayV1<int>();
            for (int i = 0; i < 10; i++)
            {
                arrayV1.AddLast(i);
            }
            Console.WriteLine(arrayV1);

            arrayV1.Add(1, 100);
            Console.WriteLine(arrayV1);

            arrayV1.AddFirst(500);
            Console.WriteLine(arrayV1);

            arrayV1.Remove(5);
            Console.WriteLine(arrayV1);

            arrayV1.Remove(6);
            Console.WriteLine(arrayV1);

            arrayV1.Remove(7);
            Console.WriteLine(arrayV1);

            #endregion

            #region 自定义类测试
            ArrayV1<Student> arr = new ArrayV1<Student>();
            arr.AddLast(new Student("ma", 100));
            arr.AddLast(new Student("song", 90));
            arr.AddLast(new Student("bo", 80));

            Console.WriteLine(arr);
            #endregion

            IStack<Int32> stack = new ArrayStack<Int32>();
            for (int i = 0; i < 5; i++)
            {
                stack.Push(i);
                Console.WriteLine(stack);
            }

            stack.Pop();
            Console.WriteLine(stack);

            ArrayQueue<int> queue = new ArrayQueue<int>();
            for (int i = 0; i < 10; i++)
            {
                queue.Enqueue(i);
                Console.WriteLine(queue);
                if (i % 3 == 2)
                {
                    queue.Dequeue();
                    Console.WriteLine(queue);
                }
            }


            Console.ReadKey();
        }
    }
}
