using Pokedex.Enums;
using System.Collections.Generic;

namespace Pokedex.Models
{
    internal abstract class Move
    {
        private readonly double? p_accuracy;
        private readonly MoveCategory p_category;
        private readonly string p_name;
        private readonly int? p_power;
        private readonly int p_pp;
        private readonly PokemonType p_type;

        public double? Accuracy
        {
            get { return p_accuracy; }
        }
        public string Name
        {
            get { return p_name; }
        }
        public int? Power
        {
            get { return p_power; }
        }
        public int Pp
        {
            get { return p_pp; }
        }

        public Move(string name, PokemonType type, MoveCategory category, int pp, int? power = null, double? accuracy = null)
        {
            p_accuracy = accuracy;
            p_name = name;
            p_power = power;
            p_pp = pp;
        }
    }
}
