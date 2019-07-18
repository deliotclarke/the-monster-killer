using System;

namespace TheMonsterKiller
{
    public class Wight : IUnholy
    {
        public void Douse(string attack)
        {
            if (attack == "Holy Water")
            {
                Console.WriteLine("You have killed the Wight with Holy Water");
            }
        }
    }
}