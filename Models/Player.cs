using Pokedex.Enums;
using System;
using System.Linq;
using System.Text;

namespace Pokedex.Models
{
    public class Player
    {
        #region Variables
        private PokemonInstance? _activePokemon;
        private bool _canFight;
        private PokemonInstance? _defaultPokemon = null;
        private Gender? _gender = null;
        private string _name = "";
        private PokemonInstance?[] _poks;
        #endregion

        #region Attributes
        public PokemonInstance? ActivePokemon
        { 
            get => this._activePokemon;
            set => this._activePokemon = value;
        }
        public bool CanFight { get => this._canFight; set => this._canFight = value; }
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
                    if (pok is not null)
                        count++;
                }
                return count;
            }
        }
            #region String Getters
        public string PokemonsDisplay
        {
            get
            {
                var output = new StringBuilder();
                output.AppendLine($"    ┌---------------------------┬---------------------------┐");
                if (this._poks[0] is not null)
                {
                    if (this._poks[0]!.IsKO)
                            output.Append($"    | {$"(K.O.) {this._poks[0]!.Nickname}", -25} |");
                    else
                        output.Append($"  1 | {$"({this._poks[0]!.Species.Name}) {this._poks[0]!.Nickname}", -25} |");
                }     
                else
                    output.Append($"    |        Empty  slot        |");
                if (this._poks[1] is not null)
                {
                    output.AppendLine($" {$"({this._poks[1]!.Species.Name}) {this._poks[1]!.Nickname}", -25} | 2");
                    if (this._poks[1]!.IsKO)
                        output.AppendLine($" {$"(K.O.) {this._poks[1]!.Nickname}", -25} |");
                }
                else
                    output.AppendLine($"        Empty  slot        |");
                output.AppendLine($"    ├---------------------------┼---------------------------┤");
                if (this._poks[2] is not null)
                {
                    if (this._poks[2]!.IsKO)
                            output.Append($"    | {$"(K.O.) {this._poks[2]!.Nickname}", -25} |");
                    else
                        output.Append($"  3 | {$"({this._poks[2]!.Species.Name}) {this._poks[2]!.Nickname}", -25} |");
                }     
                else
                    output.Append($"    |        Empty  slot        |");
                if (this._poks[3] is not null)
                {
                    output.AppendLine($" {$"({this._poks[3]!.Species.Name}) {this._poks[3]!.Nickname}", -25} | 4");
                    if (this._poks[3]!.IsKO)
                        output.AppendLine($" {$"(K.O.) {this._poks[3]!.Nickname}", -25} |");
                }
                else
                    output.AppendLine($"        Empty  slot        |");
                output.AppendLine($"    ├---------------------------┼---------------------------┤");
                if (this._poks[4] is not null)
                {
                    if (this._poks[4]!.IsKO)
                            output.Append($"    | {$"(K.O.) {this._poks[4]!.Nickname}", -25} |");
                    else
                        output.Append($"  5 | {$"({this._poks[4]!.Species.Name}) {this._poks[4]!.Nickname}", -25} |");
                }     
                else
                    output.Append($"    |        Empty  slot        |");
                if (this._poks[5] is not null)
                {
                    output.AppendLine($" {$"({this._poks[5]!.Species.Name}) {this._poks[5]!.Nickname}", -25} | 6");
                    if (this._poks[5]!.IsKO)
                        output.AppendLine($" {$"(K.O.) {this._poks[5]!.Nickname}", -25} |");
                }
                else
                    output.AppendLine($"        Empty  slot        |");
                output.AppendLine($"    └---------------------------┴---------------------------┘");

                return output.ToString();
            }
        }
            # endregion
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
            #region Abandon Pokemon
        /// <summary>
        /// Abandon the Pokemon at specific index in the Pokemons Array
        /// </summary>
        /// <param name="move">The Pokemon to add</param>
        public bool AbandonPokemon(int index)
        {
            if (this._poks[index] is not null)
            {
                this._poks[index]!.Owner = null;
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
                if (this._poks[index] is not null &&
                    this._poks[index]?.Nickname == nickname)
                {
                    this._poks[index]!.Owner = null;
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
                else if (this._defaultPokemon == this._poks[index])
                    this._defaultPokemon = poke;
                this._poks[index] = poke;
                poke.Owner = this;
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
                if (poke is not null && !poke.IsKO && poke.CurrentStats.Get(Stat.HP) > 0)
                    _canFight = true;
            }
        }
            #endregion
            #region ModifyDefaultPokemon
        public void ModifyDefaultPokemon(int index)
        {
            if (this._poks[index] is not null)
                this._defaultPokemon = this._poks[index]!;
        }
        public void ModifyDefaultPokemon(string nickname)
        {
            for (int index = 0; index < this._poks.Length; index++)
            {
                if (this._poks[index] is not null &&
                    this._poks[index]!.Nickname == nickname)
                {
                    ModifyDefaultPokemon(index);
                    return;
                }
            }
        }
            #endregion
            #region SwitchPokemon
        public bool SwitchPokemon(int index)
        {
            if (this._poks[index] is not null)
            {
                if (!this._poks[index]!.IsKO)
                {
                    this._activePokemon = this._poks[index]!;
                    Console.WriteLine($"{this._activePokemon.Nickname} is Now figthing for {this._name}");
                    this.CheckCanFight();
                    return true;
                }
                else
                    Console.WriteLine("This Pokemon is K.O.");
                    return false;
            }
            else
                return false;
        }

        public bool SwitchPokemon(string nickname)
        {
            for (int index = 0; index < this._poks.Length; index++)
            {
                if (this._poks[index] is not null &&
                    this._poks[index]!.Nickname == nickname)
                {
                    return SwitchPokemon(index);
                }
            }
            return false;
        }
            #endregion
        #endregion
    }
}
