using src_HeroopQuest.Gameclassen;
using src_HeroopQuest.Properties;
using System;
using System.Collections.Generic;

namespace src_HeroopQuest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Resources.barbaarTekst);

            Held held1 = new Held(HeldType.Barbaar,"Canon");
            Held held2 = new Held(HeldType.Tovenaar, "Bart");

            held1.ToonFiche();
            held2.ToonFiche();

            List<Held> deHelden = new List<Held>();
            List<Held> deHelden = new List<Held>();
        }
    }
}