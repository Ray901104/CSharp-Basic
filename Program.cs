using System;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int hp = 0;
            bool isDead = (hp <= 0);

            if (isDead)
            {
                Console.WriteLine("You are dead!");
            }
            else
            {
                Console.WriteLine("You are alive!");
            }

            int choice = 0; // 0 : 가위, 1 : 바위, 2: 보

            if (choice == 0)
            {
                Console.WriteLine("가위입니다.");
            }
            else if (choice == 1)
            {
                Console.WriteLine("바위입니다.");
            }
            else
            {
                Console.WriteLine("보입니다.");
            }
        }
    }
}
