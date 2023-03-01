using System;
using System.Collections;
using System.Reflection;

namespace CSharp
{
    public class Reflection
    {
        class Important : System.Attribute
        {
            string message;

            public Important(string message)
            {
                this.message = message;
            }
        }
        class PlayerA
        {
            // 컴퓨터가 런타임때 체크할 수 있는 주석
            [Important("Very Important")]
            public int hp;
            protected int attack;
            private float speed;
            
            void Attack(){}
        }
        
        static void Main(string[] args)
        {
            PlayerA playerA = new PlayerA();

            Type type = playerA.GetType();

            FieldInfo[] fieldInfos = type.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Instance);
            foreach (FieldInfo fieldInfo in fieldInfos)
            {
                string access = "protected";
                if (fieldInfo.IsPublic)
                    access = "public";
                else if (fieldInfo.IsPrivate)
                    access = "private";

                IEnumerable customAttributes = fieldInfo.GetCustomAttributes();

                Console.WriteLine($"{access} {fieldInfo.FieldType.Name} {fieldInfo.Name}");
            }
        }
    }
}