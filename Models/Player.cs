using Pokedex.Enums;
using System;
using System.Collections.Generic;

namespace Pokedex.Models
{
    public class Player
    {
        private string _name = "";
        private Gender? _gender = null;
        private List<PokemonInstance> _poks;

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

        public void AddPokemon(PokemonInstance pok)
        {
            InsertByLevel(pok);
            Console.WriteLine(pok.Nickname + " joined your team !\n");
        }

        public Gender? Gender
        {
            get { return _gender; }
        }

        public string Name
        {
            get { return _name; }
        }

        public List<PokemonInstance> Pokemons
        {
            get { return _poks; }
            set { _poks = value; }
        }

        public Player(string name, Gender gender, List<PokemonInstance> poks = null)
        {
            _gender = gender;
            _name = name;
            _poks = poks;
            _poks = new List<PokemonInstance>();
        }
    }
}
