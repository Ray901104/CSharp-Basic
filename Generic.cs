using System;

namespace CSharp
{
    public class Generic
    {
        // 모든 타입에서 동작 : Generic
        class MyList<T>
        // class MyList<T> where T : struct // T가 값 형식이어야 한다. (참조 X)
        // class MyList<T> where T : class // T가 class 형식이어야 한다.
        // class MyList<T> where T : new() // MyList<T> 클래스가 반드시 기본생성자를 가지고 있어야 한다.
        // class MyList<T> where T : TestClass // T가 TestClass 혹은 그를 상속받은 클래스 타입이어야 한다.
        {
            T[] arr = new T[10];

            public T GetItem(int i)
            {
                return arr[i];
            }
            
            public static void Test<T>(T input)
            {
                Console.WriteLine(input);
            }
        }

        class TestClass
        {
            
        }
        
        static void Main(string[] args)
        {
            MyList<int> myIntList = new MyList<int>();
            int item = myIntList.GetItem(0);
            Console.WriteLine(item);
            
            MyList<string> myStringList = new MyList<string>();
            string item2 = myStringList.GetItem(0);
            Console.WriteLine(item2);
            
            MyList<int>.Test(25);
        }
    }
}