using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.BridgeAndStrategy
{
    class Pirate
    {
        int health = 100;

        ISmokeBehavior smokeBehavior;
        public ISmokeBehavior SmokeBehavior
        {
            set => smokeBehavior = value;
            get => smokeBehavior;
        }

    }

    class Yunga : Pirate
    {

    }

    class Botson : Pirate
    {

    }

    class Captain : Pirate 
    { 
    
    }
    
}

}
