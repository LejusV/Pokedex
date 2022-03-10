using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace Pokedex.Models
{
    public abstract class PokemonInstance
    {
        #region Variables
        //PokemonDB db = new PokemonDB();

        //public void connection
        private static int instanceCount = 0;

        private readonly int _id; // ID of the pokemon in the pokedex determining what pokemon it is

        protected int _level; // Level of the Pokemon
        private string _nickname; // Name Given by User

        protected PokemonSpecies _species; // Specie of Pokemon
        
        protected PokeType _type; // Type N°1 of the PokemonInstance 
        protected PokeType _type2; // Types of the PokemonInstance
        protected PokemonStats _iv; // Individual Values which are different from two pokemons of the same specie (random)
        protected PokemonStats _ev; // Effort Values increasing with battle wins
        protected PokemonStats _calculatedStats; // Real max stats that will be shown, for example MaxHp (updated when player levels up)
        protected PokemonStats _currentStats; // Current stats such as current hp, not always equal to max HP, attack != calculated attack if (de)buffed
        private PokemonStats _statModifiers; // Modifiers of the stats in battle (from -8 to +8)

        protected Move[] _moves; // List of all the Moves the PokemonInstance has learnt
        #endregion

        #region Attributes
            #region XML AttributesList
            /// <list type="bullet">
            ///     <listheader>
            ///         <term>Getters List</term>
            ///         <description>All the getter methods</description>
            ///     </listheader>
            ///     <item>
            ///         <term>Nickname</term>
            ///         <description>Nickname Getter AND SETTER</description>
            ///     </item>
            ///
            ///     <item>
            ///         <term>Id</term>
            ///         <description>Id Getter</description>
            ///     </item>
            ///
            ///     <item>
            ///         <term>Level</term>
            ///         <description>Level Getter</description>
            ///     </item>
            ///
            ///     <item>
            ///         <term>Moves</term>
            ///         <description>Moves Getter</description>
            ///     </item>
            ///
            ///     <item>
            ///         <term>IV</term>
            ///         <description>IV Getter</description>
            ///     </item>
            ///
            ///     <item>
            ///         <term>EV</term>
            ///         <description>EV Getter</description>
            ///     </item>
            ///
            ///     <item>
            ///         <term>CalculatedStats</term>
            ///         <description>CalculatedStats Getter</description>
            ///     </item>
            ///
            ///     <item>
            ///         <term>CurrentStats</term>
            ///         <description>CurrentStats Getter</description>
            ///     </item>
            ///
            ///     <item>
            ///         <term>Specie</term>
            ///         <description>Specie Getter</description>
            ///     </item>
            /// </list>
            #endregion

            #region InstanceCount Static Getter
            public static int InstanceCount { get => instanceCount;}
            #endregion

            #region Nickname Getter
            /// <summary>
            /// <c>Nickname</c> Getter AND SETTER
            /// <returns>Returns the Nickname</returns>
            /// </summary>
            public string Nickname
            {
                get => this._nickname;
                set { this._nickname = value; }
            }
            #endregion

            #region Id Getter
            /// <summary>
            /// Id Getter
            /// </summary>
            /// <returns>Returns the Id</returns>
            public int Id { get => this._id; }
            #endregion

            #region Types Getter
            /// <summary>
            /// Types Getter
            /// </summary>
            /// <returns>Returns the Types tuple</returns>
            #nullable enable
            public (PokeType, PokeType?) Types { get => (this._type, this._type2); }
            #nullable restore
            #endregion

            #region Level Getter
            /// <summary>
            /// Level Getter
            /// </summary>
            /// <returns>Returns the Level</returns>
            public int Level { get => this._level; }
            #endregion

            #region Moves Getter
            /// <summary>
            /// Moves Getter
            /// </summary>
            /// <returns>Returns an array of Moves</returns>
            public Move[] Moves { get => this._moves; }
            #endregion

            #region IV Getter
            /// <summary>
            /// IV Getter
            /// </summary>
            /// <returns>Returns the IV PokemonStats</returns>
            public PokemonStats IV { get => this._iv;}
            #endregion

            #region EV Getter
            /// <summary>
            /// EV Getter
            /// </summary>
            /// <returns>Returns the EV PokemonStats</returns>
            public PokemonStats EV { get => _ev; }
            #endregion

            #region CalculatedStats Getter
            /// <summary>
            /// CalculatedStats Getter
            /// </summary>
            /// <returns>Returns the Calculated Base PokemonStats (Max HP, current base speed, ...)</returns>
            public PokemonStats CalculatedStats { get => this._calculatedStats; }
            #endregion

            #region BattleStats Getter
            /// <summary>
            /// CurrentStats Getter
            /// </summary>
            /// <returns>Returns the Actual Current PokemonStats (current HP if hurt, attack if (de)buffed, ...)</returns>
            public PokemonStats CurrentStats { get => this._currentStats;}
            #endregion

            #region StatModifiers Getter
            /// <summary>
            /// StatModifiers Getter
            /// </summary>
            /// <returns>Returns the Stat Modifiers (from -8 to +8)</returns>
            public PokemonStats StatModifiers { get => this._statModifiers;}
            #endregion

            #region Species Getter
            /// <summary>
            /// Species Getter
            /// </summary>
            /// <returns>Returns the PokemonSpecies</returns>
            public PokemonSpecies Species { get => this._species;}
            #endregion

            #region Types ToString
            /// <summary>
            /// Types Display
            /// </summary>
            /// <returns>Returns the formated Types string</returns>
            public string TypesString
            {
                get
                {
                    if (_type2 != null)
                        return $"{this._type} Type";
                    else
                        return $"{this._type} - {this._type2} Types";
                }
            }
            #endregion

            #region Moves List ToString
            /// <summary>
            /// Learned Moves Display
            /// </summary>
            /// <returns>Returns the formated learned moves</returns>
            public string MovesDisplay()
            {
                string res = "";
                foreach (Move m in _moves) res += m.Name + "\n";
                return res+"\n";
            }
            #endregion
        
            #region Status ToString
            /// <summary>
            /// Status Display
            /// </summary>
            /// <returns>Returns the fast Status string of this PokemonInstance</returns>
            public string Status
            {
                get
                {
                    StringBuilder output = new StringBuilder();

                    output.AppendLine($"┌------------------┐");

                    output.AppendLine($"| {this.Nickname, -16} |");
                    output.AppendLine($"| LvL{this.Level, 3}           |");

                    output.AppendLine($"|                  |");

                    output.Append($"|   {this.CurrentStats.Get("HP"), 3}");
                    output.AppendLine($" / {this.CalculatedStats.Get("HP"), 3} HP   |");

                    output.AppendLine($"└------------------┘");

                    return output.ToString();
                }
            }
            #endregion

            #region FullStatus ToString
            /// <summary>
            /// FullStatus Display
            /// </summary>
            /// <returns>Returns the full Status string of this PokemonInstance</returns>
            public string FullStatus
            {
                get
                {
                    StringBuilder output = new StringBuilder();

                    output.AppendLine($"{this._nickname}");

                    output.Append($"  {this._species.Name} ");
                    output.AppendLine($"Lvl.{this._level}");

                    output.AppendLine("");

                    output.AppendLine($"  Specie Attributes :");

                    output.AppendLine("");

                    output.AppendLine($"    Morphology :");

                    output.AppendLine($"      Height {string.Format("{0:0.0}",this._species.Height), 5}m");
                    output.AppendLine($"      Weight {string.Format("{0:0.0}",this._species.Weight), 5}kg");

                    output.AppendLine("");

                    output.AppendLine($"    Stats : ");

                    output.Append($"      HP     {this._species.Stats.Get("HP"), 3}  ");
                    output.AppendLine($"SPEED  {this._species.Stats.Get("SPEED"), 3}");
                    output.Append($"      ATK    {this._species.Stats.Get("ATK"), 3}  ");
                    output.AppendLine($"DEF    {this._species.Stats.Get("DEF"), 3}");
                    output.Append($"      SP_ATK {this._species.Stats.Get("SP_ATK"), 3}  ");
                    output.AppendLine($"SP_DEF {this._species.Stats.Get("SP_DEF"), 3}");

                    output.AppendLine("");

                    output.AppendLine($"  Actual Status :");

                    output.AppendLine($"           {this._currentStats.Get("HP"), 3} / {this._calculatedStats.Get("HP"), 3} HP     ");
                    output.Append($"      ATK    {this._currentStats.Get("ATK"), 3}  ");
                    output.AppendLine($"DEF    {this._currentStats.Get("DEF"), 3}");
                    output.Append($"      SP_ATK {this._currentStats.Get("SP_ATK"), 3}  ");
                    output.AppendLine($"SP_DEF {this._currentStats.Get("SP_DEF"), 3}");
                    output.AppendLine($"            SPEED  {this._currentStats.Get("SPEED"), 3}      ");

                    output.AppendLine("");

                    output.AppendLine($"  Learned Moves :");


                    output.Append($"    ({this._moves[0].PokeType.Name}) {this._moves[0].Name}");
                    output.AppendLine($"    ({this._moves[1].PokeType.Name}) {this._moves[1].Name}");

                    output.AppendLine("");

                    return output.ToString();
                }
            }
            #endregion

        #endregion 

        #region Constructors
        
            #region Double Type Pokemon (BASE CONSTRUCTOR)
        public PokemonInstance(
            int id,
            PokemonSpecies specie,
            string nickname,
            int level,
            PokeType type,
#nullable enable
            PokeType? type2
#nullable restore
            )
        {
            _id = id;
            _level = level;
            if (nickname != "")
                _nickname = nickname;
            else throw new ArgumentException("Name cannot be empty");
            _species = specie;
            _type = type;
            _type2 = type2;
            GenerateIV();
            _ev = new PokemonStats(0, 0, 0, 0, 0, 0);
            _calculatedStats = new PokemonStats(0, 0, 0, 0, 0, 0);
            _currentStats = new PokemonStats(0, 0, 0, 0, 0, 0);
            _statModifiers = new PokemonStats(0, 0, 0, 0, 0, 0);
            _moves = new Move[4];

            instanceCount++;
        }
            #endregion

            #region Single Type Pokemon
        public PokemonInstance(
            int id,
            PokemonSpecies specie,
            string nickname,
            int level,
            PokeType type
            )
            : this(id, specie, nickname, level, type, null)
        {}
            #endregion
            
        #endregion

        #region Methods

            #region Forget Move
        /// <summary>
        /// Forget the Move at specific index in the Moves Array
        /// </summary>
        /// <param name="move">The Move to add</param>
        public bool ForgetMove(int index)
        {
            if (this._moves[index] != null)
            {
                this._moves[index] = null;
                return true;
            }
            else 
                return false;
        }

        /// <summary>
        /// Forget the Move given in params
        /// </summary>
        /// <param name="move">The Move to forget</param>
        public bool ForgetMove(Move move)
        {
            int indexOfMove = this._moves
                .ToList()
                .IndexOf(move);
            if (indexOfMove != -1)
                return this.ForgetMove(indexOfMove);
            else
                return false;
        }
            #endregion

            #region Learn Move
        /// <summary>
        /// Learn a Move at specific index in the Moves Array
        /// </summary>
        /// <param name="move">The Move to add</param>
        public bool LearnMove(Move move, int index)
        {
            if (!this._moves.Contains(move) &&
                this._species.MoveList.Contains(move.Name))
                {
                    this._moves[index] = move;
                    return true;
                }
            else 
                return false;
        }

        /// <summary>
        /// Add a Move to the first NULL cell of array
        /// </summary>
        /// <param name="move">The Move to add</param>
        public bool LearnMove(Move move)
        {
            int indexOfNull = this._moves
                .ToList()
                .IndexOf(null);

            if (indexOfNull != -1)
                return this.LearnMove(move, indexOfNull);
            else
                return false;
        }
            #endregion

            #region GenerateIV
        /// <summary>
        /// Generates a PokemonStats Class with random values between 0 and 31
        /// </summary>
        public void GenerateIV()
        {
            Random rnd = Program.Random;
            _iv = new PokemonStats(rnd.Next(0, 31) , rnd.Next(0, 31) , rnd.Next(0, 31) , rnd.Next(0, 31) , rnd.Next(0, 31) , rnd.Next(0, 31));
        }
            #endregion
            
            #region CalculateStats
        /// <summary>
        /// Calculates this PokemonInstance Stats depending on Specie Stats, Level, IV, EV
        /// </summary>
        public void CalculateStats()
        {
            this._calculatedStats.Set( "HP" , (int) ( ( 2 * _species.Stats.Get("HP") + _iv.Get("HP") + (_ev.Get("HP") / 4) ) * _level / 100 ) + _level + 10 );

            foreach (string key in PokemonStats.Keys)
            {
                int _base = _species.Stats.Get(key);
                int iv = _iv.Get(key);
                int ev = _ev.Get(key);

                this._calculatedStats.Set( key , (int) ( ( 2*_base + iv +  ev/4 ) * _level / 100 ) + 5 );
            }
        }
        // HP Formula (2*base + iv +  ev/4 * level)/100  + level + 10
        // Other Stats Formula (2*base + iv + ev/4 * level)/100  + 5
            #endregion

            #region ResetCurrentStats
        /// <summary>
        /// Resets the Current alterable stats of this PokemonInstance, used after or at the beginning of a Battle and after leveling up
        /// </summary>
        public void ResetCurrentStats()
        {
            this._calculatedStats.CopyTo(this._currentStats);
            this._currentStats.Set("HP", this._currentStats.Get("HP"));
        }
            #endregion

        #endregion
    }
}