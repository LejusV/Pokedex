using System.Collections.Generic;

namespace Pokedex.Models
{
    public class PokemonSpecie
    {
        private readonly string _genus;
        private readonly double _height;
        private readonly string _name;
        private readonly PokemonStats _stats;
        protected readonly double _weight;

        protected string Genus { get => _genus; }

        protected double Height { get => _height; }

        public string Name { get => _name; }

        public PokemonStats Stats { get => _stats; }

        public double Weight { get => _weight; }

        public PokemonSpecie(string name, int hp, int attack, int defense, int sp_attack, int sp_defense, int speed)
        {
            _name = name;
            _stats = new PokemonStats(hp, attack, defense, sp_attack, sp_defense, speed);
        }
    }
}