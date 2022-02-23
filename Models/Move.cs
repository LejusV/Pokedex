using Pokedex.Enums;
using System.Collections.Generic;

namespace Pokedex.Models
{
    public abstract class Move
    {
        private readonly double? _accuracy;
        private readonly MoveCategory _category;
        private readonly string _name;
        private readonly PokemonType _pokemontype;
        private readonly int? _power;
        private readonly int _pp;
        private readonly int _priority;

        public double? Accuracy
        {
            get { return _accuracy; }
        }

        public MoveCategory Category
        {
            get { return _category; }
        }

        public string Name
        {
            get { return _name; }
        }

        public PokemonType PokemonType
        {
            get { return _pokemontype; }
        }

        public int? Power
        {
            get { return _power; }
        }

        public int Pp
        {
            get { return _pp; }
        }

        public int Priority
        {
            get { return _priority; }
        }

        public Move(string name, PokemonType type, MoveCategory category, int pp, int? power, double? accuracy, int priority)
        {
            _accuracy = accuracy;
            _category = category;
            _name = name;
            _pokemontype = type;
            _power = power;
            _pp = pp;
            _priority = priority;
        }
    }
}
