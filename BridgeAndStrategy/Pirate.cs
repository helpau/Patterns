using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.BridgeAndStrategy
{
    class Pirate
    {
        protected int health = 100;

        protected ISmokeBehavior smokeBehavior;
        protected IDrinkBehavior drinkBehavior;
        protected IShootBehavior shootBehavior;
        public void Smoke()
        {
            smokeBehavior.Smoke();
        }
        public void Drink()
        {
            drinkBehavior.Drink();
        }
        public void Shoot()
        {
            shootBehavior.Shoot();
        }
        

    }

    class Yunga : Pirate
    {
        public Yunga()
        {
            smokeBehavior = new NoSmoke();
            drinkBehavior = new DrinkRom();
            
        }
    }

    class Botson : Pirate
    {
        public Botson()
        {
            smokeBehavior = new SmokeTabacco();
        }
    }

    class Captain : Pirate
    {
        public Captain()
        {
            smokeBehavior = new SmokeSnuff();
        }
    }

}

