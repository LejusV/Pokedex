using System.Collections.Generic;

namespace Pokedex.Models
{
    public abstract class PokemonType
    {
        public string Name { get; }

        public Dictionary<PokemonType, double> EffectOn { get; }

        public PokemonType(string name, Dictionary<PokemonType, double> effectOn)
        {
            this.Name = name;
            this.EffectOn = effectOn;
        }
    }
}