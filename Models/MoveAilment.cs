using Pokedex.Enums;
using System.Collections.Generic;

namespace Pokedex.Models
{
    public class MoveAilment
    {
        public Ailment Type { get; }
        public int Chance { get; }
        public MoveAilment(Ailment type, int chance)
        {
            this.Type = type;
            this.Chance = chance;
        }
    }
}