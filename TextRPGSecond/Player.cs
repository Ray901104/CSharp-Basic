namespace CSharp
{
    public enum PlayerType
    {
        None = 0,
        Knight = 1,
        Archer = 2,
        Mage = 3
    }
    public class Player : Creature
    {
        protected PlayerType type = PlayerType.None;
        private int exp = 0;
        private int level = 1;

        protected Player(PlayerType type) : base(CreatureType.Player)
        {
            this.type = type;
        }

        public PlayerType GetPlayerType()
        {
            return type;
        }

        public int GetExp()
        {
            return exp;
        }

        public void SetExp(int exp)
        {
            this.exp = exp;
        }

        public int GetLevel()
        {
            return level;
        }

        public void SetLevel(int level)
        {
            this.level = level;
        }
        
        public void IncreaseExp(int exp)
        {
            this.exp += exp;
        }
    }

    class Knight : Player
    {
        public Knight() : base(PlayerType.Knight)
        {
            SetInfo(100, 10);
        }
    }

    class Archer : Player
    {
        public Archer() : base(PlayerType.Archer)
        {
            SetInfo(75, 12);
        }
    }

    class Mage : Player
    {
        public Mage() : base(PlayerType.Mage)
        {
            SetInfo(50, 15);
        }
    }
}