using System;

namespace ArrayDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayV1 arrayV1 = new ArrayV1(20);
            for (int i = 0; i < 10; i++)
            {
                arrayV1.AddLast(i);
            }
            Console.WriteLine(arrayV1);

            Console.ReadKey();
        }
    }
}
