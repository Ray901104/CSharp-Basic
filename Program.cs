using System;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // 0:가위 1:바위 2:보
            Random random = new Random();
            int aiChoice = random.Next(0, 3); // 0 ~ 2 사이의 랜덤 값

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 0:
                    Console.WriteLine("[당신] 가위!");
                    break;
                case 1:
                    Console.WriteLine("[당신] 바위!");
                    break;
                case 2:
                    Console.WriteLine("[당신] 보!");
                    break;
            }
            
            switch (aiChoice)
            {
                case 0:
                    Console.WriteLine("[AI] 가위!");
                    break;
                case 1:
                    Console.WriteLine("[AI] 바위!");
                    break;
                case 2:
                    Console.WriteLine("[AI] 보!");
                    break;
            }
            
            // ver.1
            // if (choice == 0)
            // {
            //     if (aiChoice == 0)
            //     {
            //         Console.WriteLine("[결과] 무승부!");   
            //     }   
            //     else if (aiChoice == 1)
            //     {
            //         Console.WriteLine("[결과] 패배!");
            //     }
            //     else
            //     {
            //         Console.WriteLine("[결과] 승리!");
            //     }
            // }
            // else if (choice == 1)
            // {
            //     if (aiChoice == 0)
            //     {
            //         Console.WriteLine("[결과] 승리!");
            //     }   
            //     else if (aiChoice == 1)
            //     {
            //         Console.WriteLine("[결과] 무승부!");
            //     }
            //     else
            //     {
            //         Console.WriteLine("[결과] 패배!");   
            //     }
            // }
            // else
            // {
            //     if (aiChoice == 0)
            //     {
            //         Console.WriteLine("[결과] 패배!");
            //     }   
            //     else if (aiChoice == 1)
            //     {
            //         Console.WriteLine("[결과] 승리!");
            //     }
            //     else
            //     {
            //         Console.WriteLine("[결과] 무승부!");
            //     }
            // }
            
            // ver.2
            if (choice == aiChoice)
            {
                Console.WriteLine("[결과] 무승부!");
            }
            else if (choice == 0 && aiChoice == 2)
            {
                Console.WriteLine("[결과] 승리!");
            }
            else if (choice == 1 && aiChoice == 0)
            {
                Console.WriteLine("[결과] 승리!");
            }
            else if (choice == 2 && aiChoice == 1)
            {
                Console.WriteLine("[결과] 승리!");
            }
            else
            {
                Console.WriteLine("[결과] 패배!");
            }
        }
    }
}
