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
     */
    class Knight
    {
        // 속성
        public int hp;
        public int attack;

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
        static void Main(string[] args)
        {
            Knight knight = new Knight();
            knight.hp = 100;
            knight.attack = 10;
            knight.Move();
            knight.Attack();
        }
    }
}