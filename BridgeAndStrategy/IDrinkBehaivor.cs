using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.BridgeAndStrategy
{
    interface IDrinkBehavior
    {
        void Drink();
    }

    public class DrinkRom : IDrinkBehavior
    {
        public void Drink()
        {
            Console.WriteLine("Пьём ром");
        }
    }

    public class DrinkJean : IDrinkBehavior
    {
        public void Drink()
        {
            Console.WriteLine("Пьём джинн");
        }
    }

    public class NoDrink : IDrinkBehavior
    {
        public void Drink()
        {
            Console.WriteLine("Не пьём");
        }
    }
}
