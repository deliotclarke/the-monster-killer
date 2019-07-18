using System;

namespace TheMonsterKiller
{
    class Program
    {
        static void Main(string[] args)
        {

            Hunter VonRimmersmark = new Hunter("Erich", "Von Rimmersmark");

            Mummy tuts = new Mummy();

            VonRimmersmark.Ignite(tuts);

        }
    }
}
