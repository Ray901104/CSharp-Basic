// using System;
//
// namespace CSharp
// {
//     // 객체지향프로그래밍
//     
//     class Program
//     {
//         enum ClassType
//         {
//             None = 0,
//             Knight = 1,
//             Archer = 2,
//             Mage = 3
//         }
//         
//         // 구조체
//         struct Player
//         {
//             public int hp;
//             public int attack;
//         }
//
//         static ClassType ChooseClass()
//         {
//             ClassType classType = ClassType.None;
//             
//             Console.WriteLine("직업을 선택하세요!");
//             Console.WriteLine("[1] 기사");
//             Console.WriteLine("[2] 궁수");
//             Console.WriteLine("[3] 법사");
//
//             string characterClass = Console.ReadLine();
//
//             switch (characterClass)
//             {
//                 case "1":
//                     classType = ClassType.Knight;
//                     break;
//                 case "2":
//                     classType = ClassType.Archer;
//                     break;
//                 case "3":
//                     classType = ClassType.Mage;
//                     break;
//             }
//             return classType;
//         }
//
//         static void CreatePlayer(ClassType classType, out Player player)
//         {
//             switch (classType)
//             {
//                 case ClassType.Knight:
//                     player.hp = 100;
//                     player.attack = 10;
//                     break;
//                 case ClassType.Archer:
//                     player.hp = 75;
//                     player.attack = 12;
//                     break;
//                 case ClassType.Mage:
//                     player.hp = 50;
//                     player.attack = 15;
//                     break;
//                 default:
//                     player.hp = 0;
//                     player.attack = 0;
//                     break;
//             }
//         }
//
//         enum MonsterType
//         {
//             None = 0,
//             Slime = 1,
//             Orc = 2,
//             Skeleton = 3
//         }
//
//         struct Monster
//         {
//             public int hp;
//             public int attack;
//         }
//
//         static void Fight(ref Player player, ref Monster monster)
//         {
//             while (true)
//             {
//                 // 플레이어가 몬스터 공격
//                 monster.hp -= player.attack;
//                 if (monster.hp <= 0)
//                 {
//                     Console.WriteLine("몬스터를 처치했습니다!");
//                     Console.WriteLine($"남은 체력 : {player.hp}");
//                     break;
//                 }
//                 
//                 // 몬스터의 반격
//                 player.hp -= monster.attack;
//                 if (player.hp <= 0)
//                 {
//                     Console.WriteLine("죽었습니다.");
//                     break;
//                 }
//             }
//         }
//         
//         static void EnterField(ref Player player)
//         {
//             while (true)
//             {
//                 Console.WriteLine("필드에 접속했습니다!");
//             
//                 // 랜덤으로 1~3 몬스터 중 하나를 리스폰
//                 Monster monster;
//                 CreateMonster(out monster);
//
//                 Console.WriteLine("[1] 전투 모드 돌입");
//                 Console.WriteLine("[2] 일정 확률로 마을로 도망가기");
//
//                 string input = Console.ReadLine();
//                 if (input == "1")
//                 {
//                     Fight(ref player, ref monster);
//                 }
//                 else if (input == "2")
//                 {
//                     // 33%
//                     Random random = new Random();
//                     int randomValue = random.Next(0, 101);
//                     if (randomValue <= 33)
//                     {
//                         Console.WriteLine("도망치는데 성공했습니다!");
//                         break;
//                     }
//                  
//                     Fight(ref player, ref monster);
//                 }
//             }
//         }
//
//         static void CreateMonster(out Monster monster)
//         {
//             // 랜덤으로 1~3 몬스터 중 하나를 리스폰
//             Random random = new Random();
//             int randomMonster = random.Next(1, 4);
//
//             switch (randomMonster)
//             {
//                 case (int) MonsterType.Slime:
//                     Console.WriteLine("슬라임이 스폰되었습니다!");
//                     monster.hp = 20;
//                     monster.attack = 2;
//                     break;
//                 case (int) MonsterType.Orc:
//                     Console.WriteLine("오크가 스폰되었습니다!");
//                     monster.hp = 40;
//                     monster.attack = 4;
//                     break;
//                 case (int) MonsterType.Skeleton:
//                     Console.WriteLine("스켈레톤이 스폰되었습니다!");
//                     monster.hp = 30;
//                     monster.attack = 3;
//                     break;
//                 default:
//                     monster.hp = 0;
//                     monster.attack = 0;
//                     break;
//             }
//         }
//         
//         static void EnterGame(ref Player player)
//         {
//             while (true)
//             {
//                 Console.WriteLine("마을에 접속했습니다!");
//                 Console.WriteLine("[1] 필드로 나가기");
//                 Console.WriteLine("[2] 로비로 돌아가기");
//
//                 string input = Console.ReadLine();
//
//                 if (input == "1")
//                 {
//                     EnterField(ref player);
//                 }
//                 else
//                 {
//                     break;
//                 }
//             }
//         }
//         
//         static void Main(string[] args)
//         {
//             while (true)
//             {
//                 // 직업 선택
//                 ClassType classType = ChooseClass();
//                 if (classType == ClassType.None)
//                 continue;
//          
//                 // 캐릭터 생성
//                 Player player;
//
//                 // 기사(100/10) 궁수(75/12) 법사(50/15)
//                 CreatePlayer(classType, out player);
//                 Console.WriteLine($"HP {player.hp} Attack {player.attack}");
//
//                 EnterGame(ref player);
//             }
//         }
//     }
// }