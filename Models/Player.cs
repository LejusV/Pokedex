using Pokedex.Enums;
using System;
using System.Linq;

namespace Pokedex.Models
{
    public class Player
    {
        #region Variables
        private bool _canFight;
        private PokemonInstance? _defaultPokemon = null;
        private Gender? _gender = null;
        private string _name = "";
        private PokemonInstance?[] _poks;
        #endregion

        #region Attributes
        public bool CanFight => this._canFight;
        public PokemonInstance? DefaultPokemon => this._defaultPokemon;
        public Gender? Gender
        {
            get { return _gender; }
        }

        public string Name
        {
            get { return _name; }
        }

        public PokemonInstance?[] Pokemons
        {
            get => _poks;
            set { _poks = value; }
        }
        
        /// <summary>
        /// Getter Property the effective count of Pokemons the player has
        /// </summary>
        /// <returns>count of pokemons</returns>
        public int PokemonsCount
        {
            get
            {
                int count = 0;
                foreach (PokemonInstance? pok in this._poks)
                {
                    if (pok != null)
                        count++;
                }
                return count;
            }
        }
        #endregion

        #region Constructors
        public Player(string name, Gender gender, PokemonInstance[]? poks = null)
        {
            _gender = gender;
            _name = name;
            _poks = poks!;
            _poks = new PokemonInstance[6];
            this.CheckCanFight();
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
                this.CheckCanFight();
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
                    this._poks[index]?.Nickname == nickname)
                {
                    this._poks[index] = null;
                    this.CheckCanFight();
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
                if (this.PokemonsCount == 0)
                    this._defaultPokemon = poke;
                this._poks[index] = poke;
                this.CheckCanFight();
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
            {
                if (this.PokemonsCount == 0)
                    this._defaultPokemon = poke;
                return this.AdoptPokemon(poke, indexOfNull);
            }
            else
                return false;
        }
            #endregion

            #region CheckCanFight
        public void CheckCanFight()
        {
            this._canFight = false;
            foreach (PokemonInstance? poke in _poks)
            {
                if (poke != null && !poke.IsKO && poke.CurrentStats.Get("HP") > 0)
                    _canFight = true;
            }
        }
            #endregion
            #region ModifyDefaultPokemon
        public void ModifyDefaultPokemon(int index)
        {
            if (this._poks[index] != null)
                this._defaultPokemon = this._poks[index]!;
        }
        public void ModifyDefaultPokemon(string nickname)
        {
            for (int index = 0; index < this._poks.Length; index++)
            {
                if (this._poks[index] != null &&
                    this._poks[index]?.Nickname == nickname)
                {
                    this._defaultPokemon = this._poks[index]!;
                    return;
                }
            }
        }
            #endregion
        #endregion
    }
}
