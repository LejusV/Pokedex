using System.Collections.Generic;

namespace Pokedex.Models
{
    public class PokemonSpecie
    {
        private readonly string _name;
        private readonly int _hp;
        private readonly int _attack;
        private readonly int _defense;
        private readonly int _specialAttack;
        private readonly int _specialDefense;
        private readonly int _speed;

        public string Name 
        { get { return _name; } }

        public int Hp 
        { get { return _hp; } }

        public int Attack 
        { get { return _attack; } }

        public int Defense
        { get { return _defense; } }

        public int SpecialAttack 
        { get { return _specialAttack; } }

        public int SpecialDefense
        { get { return _specialDefense; } }

        public int Speed
        { get { return _speed; } }

        public PokemonSpecie(string name, int hp, int attack, int defense, int sp_attack, int sp_defense, int speed)
        {
            _attack = attack;
            _defense = defense;
            _hp = hp;
            _specialAttack = sp_attack;
            _specialDefense = sp_defense;
            _speed = speed;
        }
    }
}