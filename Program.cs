using System;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 97; // 1, 97 로만 나뉘는 숫자
            bool isPrime = true;
            
            // break
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                    break; // 여기서 if 문을 빠져나가는 것이 아니라 for, switch 같은 특정 문법 내부를 빠져나감
                }
            }

            if (isPrime)
            {
                Console.WriteLine("소수입니다!");
            }
            else
            {
                Console.WriteLine("소수가 아닙니다!");
            }
            
            // continue
            for (int i = 1; i <= 100; i++)
            {
                if ((i % 3) != 0)
                {
                    continue;
                }
                Console.WriteLine($"3으로 나뉘는 숫자 발견 : {i}");
            }
        }
    }
}