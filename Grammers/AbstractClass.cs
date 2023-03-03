using System;
using System.Collections.Generic;

namespace CSharp
{
    // abstract : 구현에 강제성을 부여
    abstract class SuperMonster
    {
        // public virtual void Shout(); <-- 구현의 강제성은 없다.
        public abstract void Shout();
    }

    interface IFlyable
    {
        void Fly();
    }

    class FlyableOrc : OrcMonster, IFlyable
    {
        public void Fly()
        {
            
        }
    }
    
    class OrcMonster : SuperMonster
    {
        public override void Shout()
        {
            Console.WriteLine("록타르 오가르!");
        }
    }

    class SkeletonMonster : SuperMonster
    {
        public override void Shout()
        {
            Console.WriteLine("꾸에에엑!");
        }
    }

    public class AbstractClass
    {
        static void DoFly(IFlyable flyable)
        {
            flyable.Fly();
        }
        
        static void Main(string[] args)
        {
            IFlyable flyable = new FlyableOrc();
            DoFly(flyable);
        }    
    }
}