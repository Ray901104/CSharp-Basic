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
        // 속성 : 인스턴스마다 다른 값을 가질 수 있다.
        // 인스턴스에 종속적
        public int hp;
        public int attack;
        
        // static : 오로지 1개만 존재
        public static int count = 1;
        public int id;

        // static 함수 : Knight 클래스에 종속적
        public static void Test()
        {
            // static 함수 안에서는 static 변수만 접근 가능
            // this.hp = 100;
            count++;
        }

        public static Knight CreateKnight()
        {
            Knight knight = new Knight();
            knight.hp = 100;
            knight.attack = 1;
            return knight;
        }
        
        // 생성자
        public Knight()
        {
            id = count;
            count++;
            
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
            
            // static 함수 호출 : 클래스에 종속적
            Knight knight4 = Knight.CreateKnight();
            // Knight.Move(); --> knight.Move(); // 인스턴스에 종속적
            Knight.Test();
        }
    }
}