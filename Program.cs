using System;

namespace CSharp
{
    class Program
    {
        enum ClassType
        {
            None = 0,
            Knight = 1,
            Archer = 2,
            Mage = 3
        }
        
        // 구조체
        struct Player
        {
            public int hp;
            public int attack;
        }

        static ClassType ChooseClass()
        {
            ClassType classType = ClassType.None;
            
            Console.WriteLine("직업을 선택하세요!");
            Console.WriteLine("[1] 기사");
            Console.WriteLine("[2] 궁수");
            Console.WriteLine("[3] 법사");

            string characterClass = Console.ReadLine();

            switch (characterClass)
            {
                case "1":
                    classType = ClassType.Knight;
                    break;
                case "2":
                    classType = ClassType.Archer;
                    break;
                case "3":
                    classType = ClassType.Mage;
                    break;
            }
            return classType;
        }

        static void CreatePlayer(ClassType classType, out Player player)
        {
            switch (classType)
            {
                case ClassType.Knight:
                    player.hp = 100;
                    player.attack = 10;
                    break;
                case ClassType.Archer:
                    player.hp = 75;
                    player.attack = 12;
                    break;
                case ClassType.Mage:
                    player.hp = 50;
                    player.attack = 15;
                    break;
                default:
                    player.hp = 0;
                    player.attack = 0;
                    break;
            }
        }
        
        static void Main(string[] args)
        {
            while (true)
            {
                // 직업 선택
                ClassType classType = ChooseClass();
                if (classType != ClassType.None)
                {
                    // 캐릭터 생성
                    Player player;

                    // 기사(100/10) 궁수(75/12) 법사(50/15)
                    CreatePlayer(classType, out player);
                    Console.WriteLine($"HP {player.hp} Attack {player.attack}");
                    
                    // 필드로 가서 몬스터와 전투
                    break;
                }
            }
        }
    }
}