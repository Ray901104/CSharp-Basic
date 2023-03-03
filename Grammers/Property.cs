using System;

namespace CSharp
{
    public class Property
    {
        // 객체지향 -> 은닉성
        class Knight
        {
            // public int hp;
            //
            // // 프로퍼티 : getter와 setter를 동시에
            // public int Hp
            // {
            //     get
            //     {
            //         return hp;
            //     }
            //     private set // setter는 내부에서만 사용하게 하고 싶을 경우
            //     {
            //         hp = value;
            //     }
            // }
            
            // 자동완성 프로퍼티 : 한줄로 위의 getter를 setter 모두 만든다.
            public int Hp { get; set; } = 100; // 100으로 초기화 하고 싶을 경우
        }
        
        static void Main(string[] args)
        {
            Knight knight = new Knight();
            knight.Hp = 80;

            int hp = knight.Hp;
            Console.WriteLine(hp);
        }
    }
}