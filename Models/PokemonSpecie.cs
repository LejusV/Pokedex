using System.Collections.Generic;

namespace Pokedex.Models
{
    public class PokemonSpecie
    {
        private readonly PokemonStats _stats;
        private readonly string _name;
        public string Name
        {
            get { return _name; }
        }

        public PokemonStats Stats
        {
            get { return _stats; }
        }

        public PokemonSpecie(string name, int hp, int attack, int defense, int sp_attack, int sp_defense, int speed)
        {
            _name = name;
            _stats = new PokemonStats(hp, attack, defense, sp_attack, sp_defense, speed);
        }
    }
}