using System;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // 연산 우선 순위
            // 1. ++ --
            // 2. * / %
            // 3. + -
            // 4. << >>
            // 5. < >
            // 6. == !=
            // 7. &
            // 8. ^
            // 9. |
            // ..
            // 다 외울 수는 없으니, 헷갈린다 싶으면 괄호로 강제 우선순위를 부여하자!
            
            // var : 명시적으로 데이터형을 정하지 않는 자료형 (C# 과 같은 정적 타입 언어의 장점을 잃어버리므로 남용은 금물)
            var num = 3;
            var num2 = "Hello World";
        }
    }
}
