using System.Collections.Generic;

namespace Pokedex.Models
{
    public abstract class PokemonType
    {
        public string Name { get; }

        public Dictionary<string, double> EffectOn { get; }

        public PokemonType(string name, Dictionary<string, double> effectOn)
        {
            this.Name = name;
            this.EffectOn = effectOn;
        }
    }
}