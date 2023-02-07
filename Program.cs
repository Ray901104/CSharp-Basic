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

        static int AddOne2(int number)
        {
            return number + 1;
        }

        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        
        // out : 값을 여러 개 반환해야 할 경우 사용한다.
        // ref 와 같이 진퉁으로 작업한다.
        static void Divide(int a, int b, out int result1, out int result2)
        {
            result1 = a / b;
            result2 = a % b;
        }
        
        static void Main(string[] args)
        {
            HelloWorld();
            int result = Add(4, 5);
            Console.WriteLine("result = " + result);

            // 복사 (짭퉁) 참조 (진퉁)
            int a = 0;
            AddOne(a);
            Console.WriteLine(a); // AddOne 에서 +1 한것은 복사된 값임

            AddOne(ref a);
            Console.WriteLine(a); // 참조값 a 를 넣었으므로 1이 증가됨

            a = AddOne2(a);
            Console.WriteLine(a);

            int num1 = 1;
            int num2 = 2;
            Swap(ref num1, ref num2);
            Console.WriteLine("num1 = " + num1);
            Console.WriteLine("num2 = " + num2);
            
            // out
            int num3 = 10;
            int num4 = 3;

            int result1;
            int result2;
            Divide(num3, num4, out result1, out result2);
            Console.WriteLine("result1 = " + result1);
            Console.WriteLine("result2 = " + result2);
        }
    }
}