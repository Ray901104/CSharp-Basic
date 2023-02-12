namespace CSharp
{
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
        static void Main(string[] args)
        {
            KnightCapsule knightCapsule = new KnightCapsule();
            knightCapsule.SetHp(100);
        }
    }
}