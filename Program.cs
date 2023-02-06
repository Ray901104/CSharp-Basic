using System;

namespace CSharp
{
    class Program
    {
        // 메소드 (함수)
        // 한정자 반환타입 이름(매개변수)
        static void HelloWorld()
        {
            Console.WriteLine("Hello World!");
        }
        
        // 덧셈함수
        static int Add(int a, int b)
        {
            return a + b;
        }

        static void AddOne(int number)
        {
            number = number + 1;
        }

        static void AddOne(ref int number)
        {
            number = number + 1;
        }

        static void Main(string[] args)
        {
            Program.HelloWorld();
            int result = Add(4, 5);
            Console.WriteLine("result = " + result);

            // 복사 (짭퉁) 참조 (진퉁)
            int a = 0;
            Program.AddOne(a);
            Console.WriteLine(a); // AddOne 에서 +1 한것은 복사된 값임

            Program.AddOne(ref a);
            Console.WriteLine(a); // 참조값 a 를 넣었으므로 1이 증가됨
        }
    }
}