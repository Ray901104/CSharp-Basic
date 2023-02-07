using System;

namespace CSharp
{
    class Program
    {
        // 오버로딩
        // 반환타입은 영향을 주지 않는다.
        static int Add(int a, int b)
        {
            Console.WriteLine("Add int 호출");
            return a + b;
        }
        
        // 선택적 매개변수
        // 세 번째 매개변수로 값을 안넣으면 기본값으로 0을 사용하겠다는 의미
        static int Add(int a, int b, int c = 0, float d = 1.0f, double e = 3.0)
        {
            Console.WriteLine("Add int 호출");
            return a + b + c;
        }
        
        static float Add(float a, float b)
        {
            Console.WriteLine("Add float 호출");
            return a + b;
        }
        
        static void Main(string[] args)
        {
            int ret1 = Add(2, 3);
            Console.WriteLine("ret = " + ret1);

            float ret2 = Add(2.0f, 3.2f);
            Console.WriteLine("ret2 = " + ret2);

            // d 자리에만 2.0f 를 넣어주고 나머지 (c, e) 는 기본값을 사용하겠다는 의미
            Add(1, 2, d: 2.0f);
        }
    }
}