using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace Pokedex.Models
{
    public abstract class PokemonInstance
    {
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

            #region CalculatedStats Getter
            /// <summary>
            /// CalculatedStats Getter
            /// </summary>
            /// <returns>Returns the Calculated Base PokemonStats (Max HP, current base speed, ...)</returns>
            public PokemonStats CalculatedStats { get; }
            #endregion

            #region CurrentStats Getter
            /// <summary>
            /// CurrentStats Getter
            /// </summary>
            /// <returns>Returns the Actual Current PokemonStats (current HP if hurt, attack if (de)buffed, ...)</returns>
            public PokemonStats CurrentStats { get; }
            #endregion

            #region EV Getter
            /// <summary>
            /// EV Getter
            /// </summary>
            /// <returns>Returns the EV PokemonStats</returns>
            public PokemonStats EV { get; }
            #endregion

            #region Is Burned
            /// <summary>
            /// IV Getter
            /// </summary>
            /// <returns>Returns the IV PokemonStats</returns>
            public bool IsBurned { get; set; }
            #endregion

            #region Is KO
            /// <summary>
            /// Is KO Getter
            /// </summary>
            /// <returns>Returns the bool IsKO</returns>
            public bool IsKO { get; set; }
            #endregion

            #region InstanceCount Static Getter
            /// <summary>
            /// Instance Count Getter
            /// </summary>
            /// <returns>Returns the Instance Count</returns>
            public static int InstanceCount { get; set; } = 0;
            #endregion

            #region IV Getter
            /// <summary>
            /// IV Getter
            /// </summary>
            /// <returns>Returns the IV PokemonStats</returns>
            public PokemonStats IV { get; }
            #endregion

            #region Level Getter
            /// <summary>
            /// Level Getter
            /// </summary>
            /// <returns>Returns the Level</returns>
            public int Level { get;}
            #endregion

            #region Moves Getter
            /// <summary>
            /// Moves Getter
            /// </summary>
            /// <returns>Returns an array of Moves</returns>
            public MoveInstance?[] Moves { get; }
            #endregion

            #region Nickname Getter
            /// <summary>
            /// <c>Nickname</c> Getter AND SETTER
            /// <returns>Returns the Nickname</returns>
            /// </summary>
            public string Nickname { get; set; }
            #endregion

            #region Species Getter
            /// <summary>
            /// Species Getter
            /// </summary>
            /// <returns>Returns the PokemonSpecies</returns>
            public PokemonSpecies Species { get; }
            #endregion

            #region StatModifiers Getter
            /// <summary>
            /// StatModifiers Getter
            /// </summary>
            /// <returns>Returns the Stat Modifiers (from -8 to +8)</returns>
            public PokemonStats StatModifiers { get; }
            #endregion

            #region Moves List ToString
            /// <summary>
            /// Learned Moves Display
            /// </summary>
            /// <returns>Returns the formated learned moves</returns>
            public string MovesDisplay()
            {
                string res = "";
                foreach (MoveInstance? m in Moves)
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

                    output.AppendLine($"{this.Nickname}");

                    output.Append($"  {this.Species.Name} ");
                    output.AppendLine($"Lvl.{this.Level}");

                    output.AppendLine("");

                    output.AppendLine($"  Specie Attributes :");

                    output.AppendLine("");

                    output.AppendLine($"    Morphology :");

                    output.AppendLine($"      Height {string.Format("{0:0.0}",this.Species.Height), 5}m");
                    output.AppendLine($"      Weight {string.Format("{0:0.0}",this.Species.Weight), 5}kg");

                    output.AppendLine("");

                    output.AppendLine($"    Stats : ");

                    output.Append($"      HP     {this.Species.Stats.Get("HP"), 3}  ");
                    output.AppendLine($"SPEED  {this.Species.Stats.Get("SPEED"), 3}");
                    output.Append($"      ATK    {this.Species.Stats.Get("ATK"), 3}  ");
                    output.AppendLine($"DEF    {this.Species.Stats.Get("DEF"), 3}");
                    output.Append($"      SP_ATK {this.Species.Stats.Get("SP_ATK"), 3}  ");
                    output.AppendLine($"SP_DEF {this.Species.Stats.Get("SP_DEF"), 3}");

                    output.AppendLine("");

                    output.AppendLine($"  Actual Status :");

                    output.AppendLine($"           {this.CurrentStats.Get("HP"), 3} / {this.CalculatedStats.Get("HP"), 3} HP     ");
                    output.Append($"      ATK    {this.CurrentStats.Get("ATK"), 3}  ");
                    output.AppendLine($"DEF    {this.CurrentStats.Get("DEF"), 3}");
                    output.Append($"      SP_ATK {this.CurrentStats.Get("SP_ATK"), 3}  ");
                    output.AppendLine($"SP_DEF {this.CurrentStats.Get("SP_DEF"), 3}");
                    output.AppendLine($"            SPEED  {this.CurrentStats.Get("SPEED"), 3}      ");

                    output.AppendLine("");

                    output.AppendLine($"  Learned Moves :");

                    output.AppendLine($"    ┌-------------------------┬-------------------------┐");
                    if (this.Moves[0] != null)
                        output.Append($"    | {$"({this.Moves[0]!.Attributes.Type.Name}) {this.Moves[0]!.Attributes.Name}", -23} |");
                    else
                        output.Append($"    |       Empty  slot       |");
                    if (this.Moves[1] != null)
                        output.AppendLine($" {$"({this.Moves[1]!.Attributes.Type.Name}) {this.Moves[2]!.Attributes.Name}", -23} |");
                    else
                    {
                        output.AppendLine($"       Empty  slot       |");
                    }
                    output.AppendLine($"    ├-------------------------┼-------------------------┤");
                    if (this.Moves[2] != null)
                        output.Append($"    | {$"({this.Moves[2]!.Attributes.Type.Name}) {this.Moves[2]!.Attributes.Name}", -23} |");
                    else
                        output.Append($"    |       Empty  slot       |");
                    if (this.Moves[3] != null)
                        output.AppendLine($" {$"({this.Moves[3]!.Attributes.Type.Name}) {this.Moves[3]!.Attributes.Name}", -23} |");
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
            Level = level;
            if (nickname != "")
                Nickname = nickname;
            else throw new ArgumentException("Name cannot be empty");
            Species = specie;
            IsKO = false;
            IsBurned = false;
            IV = GenerateIV();
            EV = new PokemonStats(0, 0, 0, 0, 0, 0);
            CalculatedStats = new PokemonStats(0, 0, 0, 0, 0, 0);
            CurrentStats = new PokemonStats(0, 0, 0, 0, 0, 0);
            StatModifiers = new PokemonStats(0, 0, 0, 0, 0, 0);
            Moves = new MoveInstance[4];
            this.CheckIsKO();
			CalculateStats();
			ResetCurrentStats();


            InstanceCount++;
        }    
        #endregion

        #region Methods

            #region Check IsKO
        /// <summary>
        /// Checks if the Pokemon is KO
        /// </summary>
        public void CheckIsKO()
        {
            if (this.CurrentStats.Get("HP") > 0)
            {
                IsKO = false;
            }
            else 
                IsKO = true;
        }
            #endregion

            #region Forget Move
        /// <summary>
        /// Forget the Move at specific index in the Moves Array
        /// </summary>
        /// <param name="move">The Move to add</param>
        public bool ForgetMove(int index)
        {
            if (this.Moves[index] != null)
            {
                this.Moves[index] = null;
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
            int indexOfMove = this.Moves
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
            if (!this.Moves.Contains(move) &&
                this.Species.MoveList.Contains(move.Attributes.Name))
                {
                    this.Moves[index] = move;
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
            int indexOfNull = this.Moves
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
            this.CalculatedStats.Set( "HP" , (int) ( ( 2 * Species.Stats.Get("HP") + IV.Get("HP") + (EV.Get("HP") / 4) ) * Level / 100 ) + Level + 10 );

            foreach (string key in PokemonStats.Keys)
            {
                int _base = Species.Stats.Get(key);
                int iv = IV.Get(key);
                int ev = EV.Get(key);

                this.CalculatedStats.Set( key , (int) ( ( 2*_base + iv +  ev/4 ) * Level / 100 ) + 5 );
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
            this.CalculatedStats.CopyTo(this.CurrentStats);
            this.CurrentStats.Set("HP", this.CurrentStats.Get("HP"));
        }
            #endregion

        #endregion
    }
}