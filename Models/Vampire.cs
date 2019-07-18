using System;

namespace TheMonsterKiller
{
    public class Vampire : ISilverSensitive
    {
        public void Stab(string attack)
        {
            if (attack == "Silver")
            {
                Console.WriteLine("You have killed the Vampire with Silver, which is totally not a thing");
            }
        }
    }
}