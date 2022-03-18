using Pokedex.Enums;
using System;
using System.Collections.Generic;

namespace Pokedex.Models
{
    public class Player
    {
        private string _name = "";
        private Gender? _gender = null;
        private PokemonInstance[] _poks;
        private bool _canFight;

        public bool CanFight => this._canFight;

        public Gender? Gender
        {
            get { return _gender; }
        }

        public string Name
        {
            get { return _name; }
        }
        int InsertByLevel(PokemonInstance pok)
        {

            int count = _poks.Count;
            for (int i = 0; i < count; i++)
            {
                if (_poks[i].Level < pok.Level)
                {
                    _poks.Insert(i, pok);
                    return 1;
                }
            }

            _poks.Add(pok);

            return 1;
        }

        public void AddPokemon(PokemonInstance poke)
        {
            InsertByLevel(poke);
            Console.WriteLine(poke.Nickname + " joined your team !\n");
            int indexOfPoke = _poks
                .ToList()
                .IndexOf(poke);
            if (indexOfPoke != -1)
                _canFight = true;
            else
                _canFight = false;
        }

        public PokemonInstance[] Pokemons
        {
            get => _poks;
            set { _poks = value; }
        }

        public Player(string name, Gender gender, PokemonInstance[] poks = null)
        {
            _gender = gender;
            _name = name;
            _poks = poks;
            _poks = new PokemonInstance[6]();
        }
    }
}
