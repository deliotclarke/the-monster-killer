
using System.Collections.Generic;

namespace TheMonsterKiller
{
    public class Hunter
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public List<string> Weapons { get; } = new List<string>() {
        "Silver", "Fire", "Holy Water"
    };

        public Hunter(string first, string last)
        {
            FirstName = first;
            LastName = last;
        }

        public void SplashWater(Wight wight)
        {
            wight.Douse("Holy Water");  // Kills with holy water
        }

        public void Ignite(Mummy mummy)
        {
            mummy.Burn("Fire");  // Kills with fire
        }

        public void WieldSilver(Vampire vamp)
        {
            vamp.Stab("Silver");   // Stabs with silver knife
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} kills monsters with the following weapons: {string.Join(", ", Weapons)}";
        }
    }
}