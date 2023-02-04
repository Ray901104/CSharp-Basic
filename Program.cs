using System;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
         
            // while
            while (count < 5)
            {
                Console.WriteLine("Hello World!");
                count++;
            }

            // do-while
            Console.WriteLine("[Do-While] Start!");
            string answer = "";
            
            do
            {
                Console.Write("나는 잘생겼다? (y/n) : ");
                answer = Console.ReadLine();
            } while (answer != "y");
            
            Console.WriteLine("정답!");
        }
    }
}