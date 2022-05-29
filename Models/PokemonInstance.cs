using System;
using System.Linq;
using System.Text;
using Pokedex.Enums;
using System.Collections.Generic;

namespace Pokedex.Models
{
    public abstract class PokemonInstance
    {
        #region Getters and Setters
            #region Effects Getter
            public List<Effect>? Effects { get; set; }
            #endregion
            #region BattleStats Getter
            /// <summary>
            /// CalculatedStats Getter
            /// </summary>
            /// <returns>Returns the Calculated Base PokemonStats (Max HP, current base speed, ...)</returns>
            public PokemonBattleStats? BattleStats { get; set; }
            #endregion
            #region BattleStatsModifiers Getter
            /// <summary>
            /// CalculatedStats Getter
            /// </summary>
            /// <returns>Returns the Calculated Base PokemonStats (Max HP, current base speed, ...)</returns>
            public PokemonBattleStats? BattleStatModifiers { get; set; }
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
            #region InstanceCount Static Getter
            /// <summary>
            /// Instance Count Getter
            /// </summary>
            /// <returns>Returns the Instance Count</returns>
            public static int InstanceCount { get; set; } = 0;
            #endregion
            #region Is Burned
            /// <summary>
            /// IV Getter
            /// </summary>
            /// <returns>Returns the IV PokemonStats</returns>
            public bool IsBurned
            {
                get
                {
                    if (this.Effects is not null)
                        return this.Effects.Contains(Effect.Burn);
                    else
                        return false;
                }
            }
            #endregion
            #region Is KO
            /// <summary>
            /// Is KO Getter
            /// </summary>
            /// <returns>Returns the bool IsKO</returns>
            public bool IsKO { get; set; }
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
            #region Owner Getter / Setter
            /// <summary>
            /// <c>Owner</c> Getter AND SETTER
            /// <returns>(Player) Owner</returns>
            /// </summary>
            public Player? Owner { get; set; }
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
            /// <returns>from -8 to +8</returns>
            public PokemonStats StatModifiers { get; }
            #endregion
        #endregion
        
        #region ToString Functions
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

                    output.AppendLine($"{this.Nickname} Status");
                    output.Append($"  {this.Species.Name} ");
                    output.AppendLine($"Lvl.{this.Level}");
                    output.AppendLine("");

                    output.AppendLine(this.Species.Status);

                    output.AppendLine($"  Actual Status :");
                    output.AppendLine($"           {this.CurrentStats.Get(Stat.HP), 3} / {this.CalculatedStats.Get(Stat.HP), 3} HP     ");
                    output.Append($"      ATK    {this.CurrentStats.Get(Stat.ATK), 3}  ");
                    output.AppendLine($"DEF    {this.CurrentStats.Get(Stat.DEF), 3}");
                    output.Append($"      SP_ATK {this.CurrentStats.Get(Stat.SP_ATK), 3}  ");
                    output.AppendLine($"SP_DEF {this.CurrentStats.Get(Stat.SP_DEF), 3}");
                    output.AppendLine($"            SPEED  {this.CurrentStats.Get(Stat.SPEED), 3}      ");
                    output.AppendLine("");

                    output.AppendLine($"  Learned Moves :");
                    output.AppendLine(this.MovesDisplay);
                    
                    return output.ToString();
                }
            }
            #endregion
            #region Moves List ToString
            /// <summary>
            /// Learned Moves Display
            /// </summary>
            /// <returns>Returns the formated learned moves</returns>
            public string MovesDisplay
            {
                get
                {
                    var output = new StringBuilder();
                    output.AppendLine($"    ┌-------------------------┬-------------------------┐");
                    if (this.Moves[0] is not null)
                        output.Append($"  1 | {$"({this.Moves[0]!.Attributes.Type.Name}) {this.Moves[0]!.Attributes.Name}", -23} |");
                    else
                    if (this.IsKO)
                        output.Append($"    |       ///////////       |");
                    else
                        output.Append($"    |       Empty  slot       |");
                    if (this.Moves[1] is not null)
                        output.AppendLine($" {$"({this.Moves[1]!.Attributes.Type.Name}) {this.Moves[1]!.Attributes.Name}", -23} | 2");
                    else
                    if (this.IsKO)
                        output.AppendLine($"       ///////////       |");
                    else
                    {
                        output.AppendLine($"       Empty  slot       |");
                    }
                    output.AppendLine($"    ├-------------------------┼-------------------------┤");
                    if (this.Moves[2] is not null)
                        output.Append($"  3 | {$"({this.Moves[2]!.Attributes.Type.Name}) {this.Moves[2]!.Attributes.Name}", -23} |");
                    else
                    if (this.IsKO)
                        output.Append($"    |       ///////////       |");
                    else
                        output.Append($"    |       Empty  slot       |");
                    if (this.Moves[3] is not null)
                        output.AppendLine($" {$"({this.Moves[3]!.Attributes.Type.Name}) {this.Moves[3]!.Attributes.Name}", -23} | 4");
                    else
                    if (this.IsKO)
                        output.AppendLine($"       ///////////       |");
                    else
                        output.AppendLine($"       Empty  slot       |");
                    output.AppendLine($"    └-------------------------┴-------------------------┘");

                    return output.ToString();
                }
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

                    output.Append($"|   {this.CurrentStats.Get(Stat.HP), 3}");
                    output.AppendLine($" / {this.CalculatedStats.Get(Stat.HP), 3} HP   |");

                    output.AppendLine($"└------------------┘");

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
            IV = GenerateIV();
            EV = new PokemonStats(0, 0, 0, 0, 0, 0);
            CalculatedStats = new PokemonStats(0, 0, 0, 0, 0, 0);
            CurrentStats = new PokemonStats(0, 0, 0, 0, 0, 0);
            StatModifiers = new PokemonStats(0, 0, 0, 0, 0, 0);
            Moves = new MoveInstance[4];
			CalculateStats();
			ResetCurrentStats();
            this.CheckIsKO();

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
            if (this.CurrentStats.Get(Stat.HP) > 0)
            {
                this.IsKO = false;
            }
            // Endure Move lets its user at 1hp whenever he is about to faint
            else if (this.Effects is not null && this.Effects.Contains(Effect.Endure))
            {
                this.IsKO = false;
                this.CurrentStats.Set(Stat.HP, 1);
                this.Effects.Remove(Effect.Endure);
            }
            else
            {
                this.IsKO = true;
            }
        }
            #endregion
            #region Forget Move
        /// <summary>
        /// Forget the Move at specific index in the Moves Array
        /// </summary>
        /// <param name="move">The Move to add</param>
        public bool ForgetMove(int index)
        {
            if (this.Moves[index] is not null)
            {
                Console.WriteLine($"{this.Nickname} forgot {this.Moves[index]!.Attributes.Name}");
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
            #region InputMoveModify
        /// <summary>
        /// Input in which slot to put the Move
        /// </summary>
        /// <param name="move">The Move to add</param>
        /// <returns>Returns the index of the slot</returns>
        public int InputMoveModify(MoveInstance move)
        {
            Console.WriteLine($"You need to forget a move in order to make {move.Owner.Nickname} learn {move.Attributes.Name}");
            Console.WriteLine(this.MovesDisplay);
            Console.WriteLine("0 to cancel");
            int index;

            if(!int.TryParse(Console.ReadLine(), out index))
            {
                return -1;
            }
            else if (index is >= 1 and <= 4)
            {
                return index - 1;
            }
            else
                return -1;
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
                    Console.WriteLine($"{this.Nickname} learned {this.Moves[index]!.Attributes.Name}");
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
            if (this.Moves.Contains(move) ||
                !this.Species.MoveList.Contains(move.Attributes.Name))
                return false;
            else
            {
                int indexOfNull = this.Moves
                    .ToList()
                    .IndexOf(null);

                if (indexOfNull != -1)
                    return this.LearnMove(move, indexOfNull);
                else
                {
                    int inputIndex = this.InputMoveModify(move);
                    if (inputIndex != -1)
                        return this.LearnMove(move, inputIndex);
                    else
                        return false;
                }
            }
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
            this.CalculatedStats.Set( Stat.HP , (int) ( ( 2 * Species.Stats.Get(Stat.HP) + IV.Get(Stat.HP) + (EV.Get(Stat.HP) / 4) ) * Level / 100 ) + Level + 10 );

            foreach (Stat key in Enum.GetValues<Stat>())
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
            this.CurrentStats.Set(Stat.HP, this.CurrentStats.Get(Stat.HP));
        }
            #endregion
        #endregion
    }
}