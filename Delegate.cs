using System;

namespace CSharp
{
    public class Delegate
    {
        // delegate -> 함수 자체를 인자로 넘겨주는 형식
        // 반환 : int, 매개변수 : void
        // OnClicked : delegate 형식의 이름
        delegate int OnClicked();

        static void ButtonPressed(OnClicked onClicked)
        {
            // 함수를 호출
            onClicked();
        }

        static int TestDelegate()
        {
            Console.WriteLine("Hello Delegate");
            return 0;
        }
        
        static int TestDelegate2()
        {
            Console.WriteLine("Hello Delegate");
            return 0;
        }
        
        // 이벤트
        static void OnInputTest()
        {
            Console.WriteLine("Input Received!");
        }
        static void Main(string[] args)
        {
            // deleage (대리자)
            ButtonPressed(TestDelegate);
            
            // delegate 안의 콜백함수를 추가로 덧붙일 수 있다.
            OnClicked onClicked = new OnClicked(TestDelegate);
            onClicked += TestDelegate2;
            
            ButtonPressed(onClicked);
            
            // 이벤트
            InputManager inputManager = new InputManager();
            inputManager.InputKey += OnInputTest;
            
            while (true)
            {
                inputManager.Update();
            }
        }
    }
}