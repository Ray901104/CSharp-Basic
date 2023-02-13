using System;

namespace CSharp
{
    class Player
    {
        protected int hp;
        protected int attack;

        // 다형성 : virtual <-> override
        public virtual void Move()
        {
            Console.WriteLine("Player 이동!");
        }
    }

    class Archer : Player
    {
        // override 앞에 sealed 를 붙이면 해당 클래스를 상속받는 자식클래스부터는 override 를 금지한다.
        public override void Move()
        {
            base.Move(); // 부모의 Move() 호출
            Console.WriteLine("Archer 이동!");
        }
    }

    class SuperArcher : Player
    {
        public override void Move()
        {
            Console.WriteLine("SuperArcher 이동!");
        }
    }
    
    class Mage : Player
    {
        public int mp;
        
        public override void Move()
        {
            Console.WriteLine("Mage 이동!");
        }
    }
    
    // 은닉성
    class KnightCapsule
    {
        // 접근 한정자 : 디폴트는 private
        // public protected private
        private int hp;
        protected int attack;
        
        public void SetHp(int hp)
        {
            this.hp = hp;
        }
    }

    class SuperKnight : KnightCapsule
    {
        void Test()
        {
            // protected - 자식클래스에서 사용 가능
            attack = 100;
        }
    }
    
    public class Capsulation
    {
        static void EnterGame(Player player)
        {
            player.Move(); // Player.Move() --> 다형성 적용 시 객체별 함수 호출
            // 클래스 형변환 ver.1
            bool isMage = player is Mage;
            if (isMage)
            {
                Mage mage = (Mage)player;
                mage.mp = 10;
            }
            
            // 클래스 형변환 ver.2
            // 주로 as 를 사용
            Mage mage2 = (player as Mage);
            if (mage2 != null)
            {
                mage2.mp = 10;
                // mage2.Move();
            }
            
            Archer archer = player as Archer;
            if (archer != null)
            {
                // archer.Move();
            }
        }
        
        static void Main(string[] args)
        {
            KnightCapsule knightCapsule = new KnightCapsule();
            knightCapsule.SetHp(100);

            Mage mage = new Mage();
            Archer archer = new Archer();
            SuperArcher superArcher = new SuperArcher();
            EnterGame(archer);

            // Mage 타입 -> Player 타입 (O)
            // Player 타입 -> Mage 타입 (?)
            // 자식 -> 부모 형변환은 자연스럽게 가능
            // 부모 -> 자식 형변환은 주의 해야 함 (런타임 에러)
            Player magePlayer = mage;
            Mage mage2 = (Mage) magePlayer;
        }
    }
}