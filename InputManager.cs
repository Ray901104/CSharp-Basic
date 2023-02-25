using System;

namespace CSharp
{
    // Observer Pattern
    public class InputManager
    {
        public delegate void OnInputKey();

        public event OnInputKey InputKey;
        
        public void Update()
        {
            if (Console.KeyAvailable == false)
                return;

            ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
            if (consoleKeyInfo.Key == ConsoleKey.A)
            {
                // 모두에게 알림
                InputKey();
            }
        }
    }
}