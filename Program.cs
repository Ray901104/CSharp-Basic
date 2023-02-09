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
        
        static void Main(string[] args)
        {
            while (true)
            {
                ClassType classType = ChooseClass();
                if (classType != ClassType.None)
                {
                    break;
                }
            }
        }
    }
}