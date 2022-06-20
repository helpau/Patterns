using Patterns.BridgeAndStrategy;
using System;

namespace Patterns
{
    class Strategy
    {
        static void Main(string[] args)
        {
            Pirate Max = new Yunga();
            Max.Smoke();
        }
    }
}