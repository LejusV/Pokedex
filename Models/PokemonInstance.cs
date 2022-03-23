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

        protected int _level; // Level of the Pokemon
        private string _nickname; // Name Given by User

        protected PokemonSpecies _species; // Specie of Pokemon
        private bool _isKO;
        private bool _isBurned;

        protected PokemonStats _iv; // Individual Values which are different from two pokemons of the same specie (random)
        protected PokemonStats _ev; // Effort Values increasing with battle wins
        protected PokemonStats _calculatedStats; // Real max stats that will be shown, for example MaxHp (updated when player levels up)
        protected PokemonStats _currentStats; // Current stats such as current hp, not always equal to max HP, attack != calculated attack if (de)buffed
        private PokemonStats _statModifiers; // Modifiers of the stats in battle (from -8 to +8)

        protected MoveInstance?[] _moves; // List of all the Moves the PokemonInstance has learnt
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


            #region Level Getter
            /// <summary>
            /// Level Getter
            /// </summary>
            /// <returns>Returns the Level</returns>
            public int Level => this._level;
            #endregion

            #region Moves Getter
            /// <summary>
            /// Moves Getter
            /// </summary>
            /// <returns>Returns an array of Moves</returns>
            public MoveInstance?[] Moves => this._moves;
            #endregion

            #region Is Burned
            /// <summary>
            /// IV Getter
            /// </summary>
            /// <returns>Returns the IV PokemonStats</returns>
            public bool IsBurned => this._isBurned;
            #endregion

            #region IV Getter
            /// <summary>
            /// IV Getter
            /// </summary>
            /// <returns>Returns the IV PokemonStats</returns>
            public PokemonStats IV => this._iv;
            #endregion

            #region EV Getter
            /// <summary>
            /// EV Getter
            /// </summary>
            /// <returns>Returns the EV PokemonStats</returns>
            public PokemonStats EV => this._ev;
            #endregion

            #region CalculatedStats Getter
            /// <summary>
            /// CalculatedStats Getter
            /// </summary>
            /// <returns>Returns the Calculated Base PokemonStats (Max HP, current base speed, ...)</returns>
            public PokemonStats CalculatedStats => this._calculatedStats;
            #endregion

            #region BattleStats Getter
            /// <summary>
            /// CurrentStats Getter
            /// </summary>
            /// <returns>Returns the Actual Current PokemonStats (current HP if hurt, attack if (de)buffed, ...)</returns>
            public PokemonStats CurrentStats => this._currentStats;
            #endregion

            #region StatModifiers Getter
            /// <summary>
            /// StatModifiers Getter
            /// </summary>
            /// <returns>Returns the Stat Modifiers (from -8 to +8)</returns>
            public PokemonStats StatModifiers => this._statModifiers;
            #endregion

            #region Species Getter
            /// <summary>
            /// Species Getter
            /// </summary>
            /// <returns>Returns the PokemonSpecies</returns>
            public PokemonSpecies Species => this._species;
            #endregion

            #region Moves List ToString
            /// <summary>
            /// Learned Moves Display
            /// </summary>
            /// <returns>Returns the formated learned moves</returns>
            public string MovesDisplay()
            {
                string res = "";
                foreach (MoveInstance? m in _moves)
                    if (m != null)
                        res += m?.Attributes.Name + "\n";
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

                    output.AppendLine($"    ┌-------------------------┬-------------------------┐");
                    if (this._moves[0] != null)
                        output.Append($"    | {$"({this._moves[0]!.Attributes.Type.Name}) {this._moves[0]!.Attributes.Name}", -23} |");
                    else
                        output.Append($"    |       Empty  slot       |");
                    if (this._moves[1] != null)
                        output.AppendLine($" {$"({this._moves[1]!.Attributes.Type.Name}) {this._moves[2]!.Attributes.Name}", -23} |");
                    else
                    {
                        output.AppendLine($"       Empty  slot       |");
                    }
                    output.AppendLine($"    ├-------------------------┼-------------------------┤");
                    if (this._moves[2] != null)
                        output.Append($"    | {$"({this._moves[2]!.Attributes.Type.Name}) {this._moves[2]!.Attributes.Name}", -23} |");
                    else
                        output.Append($"    |       Empty  slot       |");
                    if (this._moves[3] != null)
                        output.AppendLine($" {$"({this._moves[3]!.Attributes.Type.Name}) {this._moves[3]!.Attributes.Name}", -23} |");
                    else
                        output.AppendLine($"       Empty  slot       |");
                    output.AppendLine($"    └-------------------------┴-------------------------┘");

                    output.AppendLine("");

                    return output.ToString();
                }
            }
            #endregion

        #endregion 

        #region Constructors
        public PokemonInstance(
            PokemonSpecies specie,
            string nickname,
            int level
            )
        {
            _level = level;
            if (nickname != "")
                _nickname = nickname;
            else throw new ArgumentException("Name cannot be empty");
            _species = specie;
            _isKO = false;
            _isBurned = false;
            _iv = GenerateIV();
            _ev = new PokemonStats(0, 0, 0, 0, 0, 0);
            _calculatedStats = new PokemonStats(0, 0, 0, 0, 0, 0);
            _currentStats = new PokemonStats(0, 0, 0, 0, 0, 0);
            _statModifiers = new PokemonStats(0, 0, 0, 0, 0, 0);
            _moves = new MoveInstance[4];
            this.CheckIsKO();
			CalculateStats();
			ResetCurrentStats();


            instanceCount++;
        }    
        #endregion

        #region Methods

            #region Check IsKO
        /// <summary>
        /// Checks if the Pokemon is KO
        /// </summary>
        public void CheckIsKO()
        {
            if (this._currentStats.Get("HP") > 0)
            {
                _isKO = false;
            }
            else 
                _isKO = true;
        }
            #endregion

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
        public bool ForgetMove(MoveInstance move)
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
        public bool LearnMove(MoveInstance move, int index)
        {
            if (!this._moves.Contains(move) &&
                this._species.MoveList.Contains(move.Attributes.Name))
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
        public bool LearnMove(MoveInstance move)
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
        public PokemonStats GenerateIV()
        {
            Random rnd = Program.Random;
            return new PokemonStats(rnd.Next(0, 31) , rnd.Next(0, 31) , rnd.Next(0, 31) , rnd.Next(0, 31) , rnd.Next(0, 31) , rnd.Next(0, 31));
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