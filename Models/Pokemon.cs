using System;
using System.Text;
using System.Collections.Generic;

namespace Pokedex.Models
{
    public abstract class Pokemon
    {
        #region Variables
        //PokemonDB db = new PokemonDB();

        //public void connection

        private readonly int _id; // ID of the pokemon in the pokedex determining what pokemon it is

        protected int _level; // Level of the Pokemon
        private string _nickname; // Name Given by User

        protected PokemonSpecie _specie; // Specie of Pokemon (to get his specie stats and name)
        
        protected PokemonType _type; // Type N°1 of the Pokemon 
        protected PokemonType _type2; // Types of the Pokemon
        protected PokemonStats _iv; // Individual Values which are different from two pokemons of the same specie (random)
        protected PokemonStats _ev; // Effort Values increasing with battle wins
        protected PokemonStats _calculated_stats; // Real max stats that will be shown, for example MaxHp (updated when player levels up)
        protected PokemonStats _current_stats; // Current stats such as current hp, not always equal to max HP, attack != calculated attack if (de)buffed

        protected List<Move> _moves; // List of all the Moves the Pokemon has learnt
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
            public (PokemonType, PokemonType?) Types { get => (this._type, this._type2); }
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
            /// <returns>Returns a List of Moves</returns>
            public List<Move> Moves { get => this._moves; }
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
            public PokemonStats CalculatedStats { get => this._calculated_stats; }
            #endregion

            #region CurrentStats Getter
            /// <summary>
            /// CurrentStats Getter
            /// </summary>
            /// <returns>Returns the Actual Current PokemonStats (current HP if hurt, attack if (de)buffed, ...)</returns>
            public PokemonStats CurrentStats { get => this._current_stats;}
            #endregion

            #region Specie Getter
            /// <summary>
            /// Specie Getter
            /// </summary>
            /// <returns>Returns the PokemonSpecie</returns>
            public PokemonSpecie Specie { get => this._specie;}
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
            /// <returns>Returns the fast Status string of this Pokemon</returns>
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
            /// <returns>Returns the full Status string of this Pokemon</returns>
            public string FullStatus
            {
                get
                {
                    StringBuilder output = new StringBuilder();

                    output.AppendLine($"{this._nickname}");

                    output.Append($"  {this._specie.Name} ");
                    output.AppendLine($"Lvl.{this._level}");

                    output.AppendLine("");

                    output.AppendLine($"  Specie Attributes :");

                    output.AppendLine("");

                    output.AppendLine($"    Morphology :");

                    output.AppendLine($"      Height {string.Format("{0:0.0}",this._specie.Height), 5}m");
                    output.AppendLine($"      Weight {string.Format("{0:0.0}",this._specie.Weight), 5}kg");

                    output.AppendLine("");

                    output.AppendLine($"    Stats : ");

                    output.Append($"      HP     {this._specie.Stats.Get("HP"), 3}  ");
                    output.AppendLine($"SPEED  {this._specie.Stats.Get("SPEED"), 3}");
                    output.Append($"      ATK    {this._specie.Stats.Get("ATK"), 3}  ");
                    output.AppendLine($"DEF    {this._specie.Stats.Get("DEF"), 3}");
                    output.Append($"      SP_ATK {this._specie.Stats.Get("SP_ATK"), 3}  ");
                    output.AppendLine($"SP_DEF {this._specie.Stats.Get("SP_DEF"), 3}");

                    output.AppendLine("");

                    output.AppendLine($"  Actual Status :");

                    output.AppendLine($"           {this._current_stats.Get("HP"), 3} / {this._calculated_stats.Get("HP"), 3} HP     ");
                    output.Append($"      ATK    {this._current_stats.Get("ATK"), 3}  ");
                    output.AppendLine($"DEF    {this._current_stats.Get("DEF"), 3}");
                    output.Append($"      SP_ATK {this._current_stats.Get("SP_ATK"), 3}  ");
                    output.AppendLine($"SP_DEF {this._current_stats.Get("SP_DEF"), 3}");
                    output.AppendLine($"            SPEED  {this._current_stats.Get("SPEED"), 3}      ");

                    output.AppendLine("");

                    output.AppendLine($"  Learned Moves :");

                    foreach (Move move in this._moves)
                        output.AppendLine($"    ({move.PokemonType.Name}) {move.Name}");

                    output.AppendLine("");

                    return output.ToString();
                }
            }
            #endregion

        #endregion 

        #region Constructors
        public Pokemon(
            int id,
            PokemonSpecie specie,
            string nickname,
            int level,
            PokemonType type,
            #nullable enable
            PokemonType? type2
            #nullable restore
            )
        {
            _id = id;
            _level = level;
            if (nickname != "")
                _nickname = nickname;
            else throw new ArgumentException("Name cannot be empty");
            _specie = specie;
            _type = type;
            _type2 = type2;
            GenerateIV();
            _ev = new PokemonStats(0, 0, 0, 0, 0, 0);
            _calculated_stats = new PokemonStats(0, 0, 0, 0, 0, 0);
            _current_stats = new PokemonStats(0, 0, 0, 0, 0, 0);
            _moves = new List<Move>();
        }

        public Pokemon(
            int id,
            PokemonSpecie specie,
            string nickname,
            int level,
            PokemonType type
            )
            : this(id, specie, nickname, level, type, null)
        {}
            
        #endregion

        #region Methods
        public void AddMove(Move move)
        {
            _moves.Add( move );
        }

        public void GenerateIV()
        {
            Random rnd = Program.Random;
            _iv = new PokemonStats(rnd.Next(0, 31) , rnd.Next(0, 31) , rnd.Next(0, 31) , rnd.Next(0, 31) , rnd.Next(0, 31) , rnd.Next(0, 31));
        }
            

        public void CalculateStats()
        {
            this._calculated_stats.Set( "HP" , (int) ( ( 2 * _specie.Stats.Get("HP") + _iv.Get("HP") + (_ev.Get("HP") / 4) ) * _level / 100 ) + _level + 10 );

            foreach (string key in PokemonStats.Keys)
            {
                int _base = _specie.Stats.Get(key);
                int iv = _iv.Get(key);
                int ev = _ev.Get(key);

                this._calculated_stats.Set( key , (int) ( ( 2*_base + iv +  ev/4 ) * _level / 100 ) + 5 );
            }
        }
        // HP Formula (2*base + iv +  ev/4 * level)/100  + level + 10
        // Other Stats Formula (2*base + iv + ev/4 * level)/100  + 5


        public void ResetCurrentStats()
        {
            this._calculated_stats.CopyTo(this._current_stats);
            this._current_stats.Set("HP", this._current_stats.Get("HP"));
        }
        #endregion
    }
}