using System;

namespace CSharp
{
    class Program
    {
        // 열거형
        enum Choice
        {
            SCISSORS = 0,
            ROCK = 1,
            PAPER = 2
        }
        
        static void Main(string[] args)
        {
            // 0:가위 1:바위 2:보
            Random random = new Random();
            int aiChoice = random.Next(0, 3); // 0 ~ 2 사이의 랜덤 값

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case (int) Choice.SCISSORS:
                    Console.WriteLine("[당신] 가위!");
                    break;
                case (int) Choice.ROCK:
                    Console.WriteLine("[당신] 바위!");
                    break;
                case (int) Choice.PAPER:
                    Console.WriteLine("[당신] 보!");
                    break;
            }
            
            switch (aiChoice)
            {
                case (int) Choice.SCISSORS:
                    Console.WriteLine("[AI] 가위!");
                    break;
                case (int) Choice.ROCK:
                    Console.WriteLine("[AI] 바위!");
                    break;
                case (int) Choice.PAPER:
                    Console.WriteLine("[AI] 보!");
                    break;
            }
            
            // ver.1
            // if (choice == SCISSORS)
            // {
            //     if (aiChoice == SCISSORS)
            //     {
            //         Console.WriteLine("[결과] 무승부!");   
            //     }   
            //     else if (aiChoice == ROCK)
            //     {
            //         Console.WriteLine("[결과] 패배!");
            //     }
            //     else
            //     {
            //         Console.WriteLine("[결과] 승리!");
            //     }
            // }
            // else if (choice == ROCK)
            // {
            //     if (aiChoice == SCISSORS)
            //     {
            //         Console.WriteLine("[결과] 승리!");
            //     }   
            //     else if (aiChoice == ROCK)
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
            //     if (aiChoice == SCISSORS)
            //     {
            //         Console.WriteLine("[결과] 패배!");
            //     }   
            //     else if (aiChoice == ROCK)
            //     {
            //         Console.WriteLine("[결과] 승리!");
            //     }
            //     else
            //     {
            //         Console.WriteLine("[결과] 무승부!");
            //     }
            // }
            
            // 상수
            const int SCISSORS = 0;
            const int ROCK = 1;
            const int PAPER = 2;
            
            // ver.2
            if (choice == aiChoice)
            {
                Console.WriteLine("[결과] 무승부!");
            }
            else if (choice == SCISSORS && aiChoice == PAPER)
            {
                Console.WriteLine("[결과] 승리!");
            }
            else if (choice == ROCK && aiChoice == SCISSORS)
            {
                Console.WriteLine("[결과] 승리!");
            }
            else if (choice == PAPER && aiChoice == ROCK)
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
