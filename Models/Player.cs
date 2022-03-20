using Pokedex.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Pokedex.Models
{
    public class Player
    {
        #region Variables
        private bool _canFight;
        private Gender? _gender = null;
        private string _name = "";
        private PokemonInstance[] _poks;
        #endregion

        #region Attributes
        public bool CanFight => this._canFight;

        public Gender? Gender
        {
            get { return _gender; }
        }

        public string Name
        {
            get { return _name; }
        }

        public PokemonInstance[] Pokemons
        {
            get => _poks;
            set { _poks = value; }
        }
        #endregion

        #region Constructors
        public Player(string name, Gender gender, PokemonInstance[] poks = null)
        {
            _gender = gender;
            _name = name;
            _poks = poks;
            _poks = new PokemonInstance[6];
        }
        #endregion

        #region Methods
            #region Pokemons Array BubbleSort
        private void PokemonsBubbleSort()
        {

        }
            #endregion

            #region Abandon Pokemon
        /// <summary>
        /// Abandon the Pokemon at specific index in the Pokemons Array
        /// </summary>
        /// <param name="move">The Pokemon to add</param>
        public bool AbandonPokemon(int index)
        {
            if (this._poks[index] != null)
            {
                this._poks[index] = null;
                return true;
            }
            else
                return false;
        }

        /// <summary>
        /// Abandon the Pokemon given in params
        /// </summary>
        /// <param name="move">The Pokemon to forget</param>
        public bool AbandonPokemon(string nickname)
        {
            for (int index = 0; index < this._poks.Length; index++)
            {
                if (this._poks[index] != null &&
                    this._poks[index].Nickname == nickname)
                {
                    this._poks[index] = null;
                    return true;
                }
            }
            return false;
        }
            #endregion

            #region Adopt Pokemon
        /// <summary>
        /// Adopt a Pokemon at specific index in the Pokemons Array
        /// </summary>
        /// <param name="move">The Pokemon to add</param>
        public bool AdoptPokemon(PokemonInstance poke, int index)
        {
            if (!this._poks.Contains(poke))
            {
                this._poks[index] = poke;

                return true;
            }
            else 
                return false;
        }

        /// <summary>
        /// Add a Pokemon to the first NULL cell of array
        /// </summary>
        /// <param name="move">The Pokemon to add</param>
        public bool AdoptPokemon(PokemonInstance poke)
        {
            int indexOfNull = this._poks
                .ToList()
                .IndexOf(null);

            if (indexOfNull != -1)
                return this.AdoptPokemon(poke, indexOfNull);
            else
                return false;
        }
            #endregion

        private void CheckCanFight()
        {
            foreach (PokemonInstance poke in _poks)
            {
                if (poke != null && poke.CurrentStats.Get("HP") > 0)
                    _canFight = true;
            }
        }
        #endregion
    }
}
