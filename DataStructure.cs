using System;
using System.Collections.Generic;

namespace CSharp
{
    public class DataStructure
    {
        class MonsterClass
        {
            public int id;

            public MonsterClass(int id)
            {
                this.id = id;
            }
        }
        
        class Map
        {
            private int[,] tiles =
            {
                { 1, 1, 1, 1, 1 },
                { 1, 0, 0, 0, 1 },
                { 1, 0, 0, 0, 1 },
                { 1, 0, 0, 0, 1 },
                { 1, 1, 1, 1, 1 }
            };
            
            public void Render()
            {
                ConsoleColor defaultColor = Console.ForegroundColor;
                for (int y = 0; y < tiles.GetLength(1); y++)
                {
                    for (int x = 0; x < tiles.GetLength(0); x++)
                    {
                        if (tiles[y, x] == 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                        }
                        Console.Write('\u25cf');
                    }
                    Console.WriteLine();
                }

                Console.ForegroundColor = defaultColor;
            }
        }

        
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
            
            // 다차원 배열
            int[,] intArr = new int[2, 3] { {1, 2, 3}, {1, 2, 3} };
            Map map = new Map();
            map.Render();
            
            // 가변 배열
            int[][] cArr = new int[3][];
            cArr[0] = new int[3];
            cArr[1] = new int[6];
            cArr[2] = new int[2];
            Console.WriteLine(cArr);
            
            // List
            List<int> list = new List<int>();
            for (int i = 0; i < 5; i++)
            { 
                list.Add(i);
            }

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            Console.WriteLine();
            // 삽입 및 삭제
            list.Insert(2, 999);
            foreach (int num in list)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine();
            list.Remove(999);
            foreach (int num in list)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine();
            list.RemoveAt(2);
            foreach (int num in list)
            {
                Console.WriteLine(num);
            }
            
            Console.WriteLine();
            list.Clear();
            foreach (int num in list)
            {
                Console.WriteLine(num);
            }
            
            // Dictionary
            // 원리 : HashTable 
            // 아주 큰 박스 [ ] 1만개 (1~10000)
            // 예를 들어 10개 단위로 박스를 쪼개 놓는다. [1~10] [11~20] ... [9991 ~ 10000] 1천개의 박스로 줄어듦
            // 7777 을 찾는다 --> 777번째 박스에 있다는것을 바로 알 수 있다.
            Dictionary<int, MonsterClass> dictionary = new Dictionary<int, MonsterClass>();
            for (int i = 0; i < 10000; i++)
            {
                dictionary.Add(i, new MonsterClass(i));
            }

            MonsterClass mon;
            bool found = dictionary.TryGetValue(20000, out mon);

            MonsterClass monster = dictionary[5000];

            dictionary.Remove(7777);
            dictionary.Clear();
        }
    }
}