using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.BridgeAndStrategy
{
    interface ISmokeBehavior
    {
        void Smoke();
    }

    class SmokeTabacco : ISmokeBehavior
    {
        public void Smoke()
        {
            Console.WriteLine("Курим табак");
        }
    }
    class SmokeSnuff : ISmokeBehavior
    {
        public void Smoke()
        {
            Console.WriteLine("Курим махорку");
        }
    }

    class NoSmoke : ISmokeBehavior
    {
        public void Smoke()
        {
            Console.WriteLine("Не курим");
        }
    }

}
