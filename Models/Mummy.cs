using System;

namespace TheMonsterKiller
{
    public class Mummy : ICombustable
    {
        public void Burn(string attack)
        {
            if (attack == "Fire")
            {
                Console.WriteLine("You just killed the Mummy");
            }
        }
    }
}