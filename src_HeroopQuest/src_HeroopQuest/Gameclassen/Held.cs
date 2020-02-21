using System;
using System.Collections.Generic;
using System.Text;

namespace src_HeroopQuest.Gameclassen
{
    enum HeldType { Barbaar, Dwerg, Elf, Tovenaar}
    class Held
    {
        public string Naam { get; set; }
        public string Beschrijving { get; private set; }
        public int MaxIntelligentie { get; private set; }
        public int MaxLichaam { get; private set; }
        public int HuidigIntelligentie { get; set; }
        public int HuidigLichaam { get; set; }
        public HeldType HeldType { get; private set; }
        public int AanvalIsDobbelStenen { get; private set; } = 2;
        public int VerdedigDobbelStenen { get; private set; } = 2;
        public int LoopDobbelStenen { get; private set; } = 2;
    }
}
