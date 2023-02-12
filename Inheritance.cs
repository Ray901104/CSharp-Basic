using System;

namespace CSharp
{
    /**
     * 객체지향프로그래밍 설계
     * 데이터 설계 : 속성과 기능으로 분류
     * Knight
     * 속성 : hp, attack
     * 기능 : Move, Attack, Die
     */

    // 상속성 : 부모클래스의 것을 자식클래스에서 사용 가능
    // 부모 클래스
    class PlayerClass
    {
        public static int count = 1;
        public int id;
        public int hp;
        public int attack;

        public PlayerClass()
        {
            Console.WriteLine("Player 생성자 호출!");
        }
        
        public PlayerClass(int hp)
        {
            this.hp = hp;
            Console.WriteLine("Player hp 생성자 호출!");
        }
        
        // 기능
        public void Move()
        {
            Console.WriteLine("Knight Move");   
        }

        public void Attack()
        {
            Console.WriteLine("Knight Attack");
        }
    }
    
    /**
     * Knight 객체 설계
     * 참조
     */
    class Knight : PlayerClass
    {
        public static Knight CreateKnight()
        {
            Knight knight = new Knight();
            knight.hp = 100;
            knight.attack = 1;
            return knight;
        }
        
        // 생성자
        public Knight() : base(100) // 부모의 hp 생성자 호출하곘다는 의미
        {
            Console.WriteLine("Knight 생성자 호출!");
        }
    }
    
    public class Inheritance
    {
        // 복사
        struct Mage
        {
            public int hp;
            public int attack;
        }
    
        static void KillMage(Mage mage)
        {
            mage.hp = 0;
        }
        
        static void KillKnight(Knight knight)
        {
            knight.hp = 0;
        }
        
        static void Main(string[] args)
        {
            Knight knight = new Knight();
            knight.Move();
            knight.Attack();
        }
    }
}