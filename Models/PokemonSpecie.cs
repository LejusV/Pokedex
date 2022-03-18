using System.Collections.Generic;

namespace Pokedex.Models
{
    public abstract class PokemonSpecies
    {
        private readonly int _id; // ID of the pokemon specie in the pokedex

        //private readonly string _genus;
        private readonly double _height;
        private readonly string _name;
        private readonly PokemonStats _stats;
        private readonly double _weight;
        protected List<string> _moveList;

        //public string Genus => _genus;

        public int Id => this._id;

        public double Height => _height;

        public string Name => _name;

        public PokemonStats Stats => _stats;

        public double Weight => _weight;
        
        public List<string> MoveList => _moveList;

        public PokemonSpecies(int id, string name, double height, double weight, int hp, int attack, int defense, int sp_attack, int sp_defense, int speed)
        {
            _id = id; // store specie id
            _height = height; // store specie height
            _name = name; // store specie name

            _stats = new PokemonStats(hp, attack, defense, sp_attack, sp_defense, speed); 
            /* creates new PokemonStats containing
             a new Dictionnary<string, int>(){{"hp", hp}, {"attack", attack}, {"hp", hp}, {"hp", hp}, {"hp", hp}, }*/

            _weight = weight;
        }

    }
}