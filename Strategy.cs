using System;

namespace Patterns
{
    class Strategy
    {
        static void Main(string[] args)
        {
            Yunga yunga = new Yunga();
        }
    }



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
    class Captain : Pirate { }
    interface ISmokeBehavior
    {
        void Smoke();
    }
    interface IDrinkBehavior
    {
        void Drink();
    }
    interface IShootBehavior
    {
        void Shoot();
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
