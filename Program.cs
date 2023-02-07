using System;

namespace CSharp
{
    class Program
    {
        // 팩토리얼
        static int Factorial(int n)
        {
            if (n <= 1)
            {
                return 1;
            }
            return n * Factorial(n - 1);
        }
        
        static void Main(string[] args)
        {
            // 구구단
            for(int i = 2; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    Console.WriteLine($"{i} * {j} = {i * j}");
                }
            }
                
            // 별찍기
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");    
                }
                Console.WriteLine();
            }

            int ret = Factorial(5);
            Console.WriteLine(ret);
        }
    }
}