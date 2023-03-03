using System;

namespace CSharp
{
    public class Nullable
    {
        class Tiger
        {
            public int Id { get; set; }
        }
        
        static int Find()
        {
            return 0;
        }
        
        static void Main(string[] args)
        {
            // Nullable
            int? number = null;

            // (number != null) ? number : 0 <-- 같은 의미
            int b = number ?? 0; // number가 null이 아니라면 number, null이라면 초기값(0) 할당
            
            // int temp = number.Value; // 예외발생
            // Console.WriteLine(temp);

            Console.WriteLine(b);
            
            Tiger tiger = null;
            int? id = tiger?.Id;
        }
    }
}