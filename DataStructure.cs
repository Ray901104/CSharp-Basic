using System;

namespace CSharp
{
    public class DataStructure
    {
        static int GetHighestScore(int[] scores)
        {
            int highestScore = 0;
            foreach (int score in scores)
            {
                highestScore = (highestScore > score) ? highestScore : score;
            }
            return highestScore;
        }

        static int GetAverageScore(int[] scores)
        {
            if (scores.Length == 0)
                return 0;
            
            int totalScore = 0;
            foreach (int score in scores)
            {
                totalScore += score;
            }
            return totalScore / scores.Length;
        }

        static int GetIndexOf(int[] scores, int value)
        {
            int idx = -1;
            for (int i = 0; i < scores.Length; i++)
            {
                if (scores[i] == value)
                    return i;
            }
            return idx;
        }

        static void Sort(int[] scores)
        {
            // int temp = 0;
            // for (int i = 0; i < scores.Length; i++)
            // {
            //     for (int j = i + 1; j < scores.Length; j++)
            //     {
            //         if (scores[i] > scores[j])
            //         {
            //             temp = scores[i];
            //             scores[i] = scores[j];
            //             scores[j] = temp;
            //         }
            //     }
            // }
            // Console.Write("[Sort] : ");
            // foreach (int score in scores)
            // {
            //     Console.Write(score + " ");
            // }
            
            for (int i = 0; i < scores.Length; i++)
            {
                int minIndex = i;
                for (int j = i; j < scores.Length; j++)
                {
                    if (scores[j] < scores[minIndex])
                    {
                        minIndex = j;
                    }
                }
                // swap
                int temp = scores[i];
                scores[i] = scores[minIndex];
                scores[minIndex] = temp;
            }
        }
        
        static void Main(string[] args)
        {
            // 배열
            // int[] scores = new int[5];
            // int[] scores = new int[5] {10, 20, 30, 40, 50};
            // int[] scores = new int[] {10, 20, 30, 40, 50};
            // int[] scores = {10, 20, 30, 40, 50};
            
            // scores[0] = 10;
            // scores[1] = 20;
            // scores[2] = 30;
            // scores[3] = 40;
            // scores[4] = 50;
            //
            // for (int i = 0; i < scores.Length; i++)
            // {
            //     Console.WriteLine(scores[i]);
            // }
            //
            // foreach (int score in scores)
            // {
            //     Console.WriteLine(score);
            // }
            
            // 연습문제
            int[] scoreArr = new int[5] { 10, 30, 40, 20, 50 };
            Console.WriteLine("[GetHighestScore] : " + GetHighestScore(scoreArr));
            Console.WriteLine("[GetAverageScore] : " + GetAverageScore(scoreArr));
            Console.WriteLine("[GetIndexOf] : " + GetIndexOf(scoreArr, 20));
            Sort(scoreArr);
        }
    }
}