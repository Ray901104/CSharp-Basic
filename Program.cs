using System;

namespace CSharp
{
    class Program
    {
        // 주석
        /* 
         * 여러 줄 
         * 주석
         */
        static void Main(string[] args)
        {
            // 정수형 : byte (1 byte), short (2 byte), int (4 byte), long (8 byte), sbyte, ushort, uint, ulong
            int hp;
            hp = 100;

            short level = 100;
            long id;

            //Console.WriteLine("Hello Number ! {0}", hp);

            // bool (1 byte) : true / false
            bool b;

            // 소수
            float f; // 4 byte
            f = 3.14f; // 일반적으로 7 자리 까지 정밀

            double d; // 8 byte
            d = 3.14;

            // 문자
            char c; // 2 byte
            c = 'a';

            // 문자열
            string str;
            str = "Hello World";

            Console.WriteLine(str);

            // 형변환
            // 1. 바구니 크기가 다른 경우!
            int a = 1000;
            short s = (short) a;
            
            // 2. 바구니 크기는 같지만 부호가 다를 경우
            byte ub = 255;
            sbyte sb = (sbyte) ub;
            
            // 3. 소수 변환
            f = 3.1414f;
            d = f;
        }
    }
}
