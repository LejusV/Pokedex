using System.Collections.Generic;

namespace Pokedex.Models
{
    public class PokemonSpecie
    {
        private readonly string _genus;
        private readonly double _height;
        private readonly string _name;
        private readonly PokemonStats _stats;
        private readonly double _weight;

        public string Genus { get => _genus; }

        public double Height { get => _height; }

        public string Name { get => _name; }

        public PokemonStats Stats { get => _stats; }

        public double Weight { get => _weight; }

        public PokemonSpecie(string name, double height, double weight, int hp, int attack, int defense, int sp_attack, int sp_defense, int speed)
        {
            _height = height; // store specie height
            _name = name; // store specie name

            _stats = new PokemonStats(hp, attack, defense, sp_attack, sp_defense, speed); 
            /* creates new PokemonStats containing
             a new Dictionnary<string, int>(){{"hp", hp}, {"attack", attack}, {"hp", hp}, {"hp", hp}, {"hp", hp}, }*/

            _weight = weight;
        }
    }
}