using System;

namespace CSharp
{
    class Program
    {
        static void Print(int value)
        {
            Console.WriteLine(value);
        }

        static int AddAndPrint(int a, int b)
        {
            int ret = a + b;
            Print(ret);
            return ret;
        }

        static void Main(string[] args)
        {
            // 디버깅
            int ret = Program.AddAndPrint(10, 20);
        }
    }
}