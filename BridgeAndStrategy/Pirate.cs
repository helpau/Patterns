using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.BridgeAndStrategy
{
    class Pirate
    {
        protected int health = 100;

        protected ISmokeBehavior smokeBehavior;

        public void Smoke()
        {
            smokeBehavior.Smoke();
        }

    }

    class Yunga : Pirate
    {
        public Yunga()
        {
            smokeBehavior = new NoSmoke();
        }
    }

    class Botson : Pirate
    {

    }

    class Captain : Pirate 
    { 
    
    }
    
}

