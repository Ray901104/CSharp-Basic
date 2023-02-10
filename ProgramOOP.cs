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
    
    /**
     * Knight 객체 설계
     * 참조
     */
    class Knight
    {
        // 속성
        public int hp;
        public int attack;

        // 생성자
        public Knight()
        {
            hp = 200;
            attack = 20;
            Console.WriteLine("생성자 호출!");
        }
        
        public Knight(int hp) : this()
        {
            this.hp = hp;
            Console.WriteLine("매개변수 생성자 호출!");
        }
        
        public Knight Clone()
        {
            Knight knight = new Knight();
            knight.hp = hp;
            knight.attack = attack;
            return knight;
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
    
    class ProgramOOP
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
            Mage mage;
            mage.hp = 100;
            mage.attack = 50;
            KillMage(mage);
            
            Mage mage2 = mage;
            mage2.hp = 0;
            
            Knight knight = new Knight(50);
            // knight.hp = 100;
            // knight.attack = 10;
            // knight.Move();
            // knight.Attack();
            KillKnight(knight);

            // 서로 분리된 객체가 됨
            Knight knight2 = knight.Clone();
            knight2.hp = 10;
        }
    }
}