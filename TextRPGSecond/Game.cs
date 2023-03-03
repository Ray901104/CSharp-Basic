using System;

namespace CSharp
{
    public enum GameMode
    {
        None,
        Lobby,
        Town,
        Field
    }
    
    public class Game
    {
        private GameMode mode = GameMode.Lobby;
        private Player player = null;
        private Monster monster = null;
        private int exp;
        private int level;
        Random random = new Random();

        public void Process()
        {
            switch (mode)
            {
                case GameMode.Lobby:
                    ProcessLobby();
                    break;
                case GameMode.Town:
                    ProcessTown();
                    break;
                case GameMode.Field:
                    ProcessField();
                    break;
            }
        }

        private void ProcessLobby()
        {
            Console.WriteLine("직업을 선택하세요");
            Console.WriteLine("[1] 기사");
            Console.WriteLine("[2] 궁수");
            Console.WriteLine("[3] 법사");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    player = new Knight();
                    mode = GameMode.Town;
                    break;
                case "2":
                    player = new Archer();
                    mode = GameMode.Town;
                    break;
                case "3":
                    player = new Mage();
                    mode = GameMode.Town;
                    break;
            }
        }

        private void ProcessTown()
        {
            Console.WriteLine("마을에 입장했습니다.");
            Console.WriteLine("[1] 필드로 이동");
            Console.WriteLine("[2] 로비로 돌아가기");
            
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    mode = GameMode.Field;
                    break;
                case "2":
                    mode = GameMode.Lobby;
                    break;
            }
        }

        private void ProcessField()
        {
            Console.WriteLine("필드에 입장했습니다.");
            Console.WriteLine("[1] 전투 시작");
            Console.WriteLine("[2] 일정 확률로 마을로 돌아가기");
            
            CreatedRandomMonster();

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    ProcessFight();
                    break;
                case "2":
                    TryEscape();
                    break;
            }
        }

        private void CreatedRandomMonster()
        {
            int randomValue = random.Next(0, 3);
            
            switch (randomValue)
            {
                case 0:
                    monster = new Slime();
                    Console.WriteLine("슬라임이 생성되었습니다!");
                    break;
                case 1:
                    monster = new Orc();
                    Console.WriteLine("오크가 생성되었습니다!");
                    break;
                case 2:
                    monster = new Skeleton();
                    Console.WriteLine("스켈레톤이 생성되었습니다!");
                    break;
            }
        }

        private void ProcessFight()
        {
            while (true)
            {
                int damage = player.GetAttack();
                monster.OnDamaged(damage);
                
                if (monster.IsDead())
                {
                    Console.WriteLine("몬스터를 처치하였습니다!");
                    Console.WriteLine($"플레이어 남은체력 : {player.GetHP()}");
                    
                    player.IncreaseExp(15);
                    exp = player.GetExp();
                    level = player.GetLevel(); 
                    if (exp >= 100)
                    {
                        player.SetExp(0);
                        player.SetHP(100);
                        player.SetLevel(++level);
                        Console.WriteLine($"레벨업 하였습니다! 현재 레벨 : {player.GetLevel()}");
                    }
                    Console.WriteLine($"경험치 : {player.GetExp()}");
                    break;
                }

                damage = monster.GetAttack();
                player.OnDamaged(damage);

                if (player.IsDead())
                {
                    Console.WriteLine("사망했습니다..");
                    mode = GameMode.Lobby;
                    break;
                }
            }
        }

        private void TryEscape()
        {
            int randomeValue = random.Next(0, 100);
            if (randomeValue < 33)
            {
                mode = GameMode.Town;
            }
            else
            {
                ProcessFight();
            }
        }
    }
}