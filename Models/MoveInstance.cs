using System;
using System.Linq;
using System.Text;
using Pokedex.Enums;

namespace Pokedex.Models
{
    public abstract class MoveInstance
    {
        # region Attributes
            #region Getters and Setters
        public Move Attributes { get; }
        public PokemonInstance Owner { get; }
        public int PP { get; private set; }
            #endregion
            #region String Getters
        public string PPStatus
        {
            get => $"{this.Attributes.Name} : {this.PP}/{this.Attributes.PP} PP";
        }
        public string FullStatus {

            get
            {
                StringBuilder output = new StringBuilder();
                // line 1
                output.AppendLine($"{this.Attributes.Name, -16}"); // Move Name (line 1)
                // line 2
                output.AppendLine("┌--------------┬--------------------┐");

                output.Append($"| Type: {this.Attributes.Type.Name, 6} |"); // Move PokemonType (line 2)
                output.AppendLine($" Category: {this.Attributes.DamageCategory, -8} |"); // Move DamageCategory (line 2)
                // line 3
                output.Append($"| Power:   {this.Attributes.Power?.ToString() ?? "-", 3} | "); // Move Power (line 3)
                output.AppendLine($"Accuracy: {this.Attributes.Accuracy?.ToString("#'%'") ?? "-", 4}     |"); // Move Accuracy (line 3)
                // line 4
                output.Append($"| PP:    {this.PP, 2}/{this.Attributes.PP, 2} | "); // Move PP (line 4)
                output.AppendLine($"Priority: {this.Attributes.Priority, -2:+#;-#;0}       |"); // Move Priority (line 4)

                output.AppendLine("└--------------┴--------------------┘");

                return output.ToString(); // output
            }
        }
            #endregion
        # endregion

        # region Constructors
        /// <summary>
        /// Constructor of the MoveInstance class
        /// </summary>
        /// <param name="owner">Owner of the Pokemon</param>
        /// <param name="attributes">The corresponding Move for its immutable Attributes</param>
        /// <param name="pp">The amount of PP it'll have on creation</param>
        public MoveInstance( PokemonInstance owner, Move attributes, int pp )
        {
            this.Attributes = attributes;
            this.Owner = owner;
            this.PP = Math.Min(attributes.PP, Math.Max(0, pp)); // Value for current PP has to be between 0 and max PP (given in its Attributes)
            owner.LearnMove(this);
        }

        /// <summary>
        /// Secondary Constructor of the MoveInstance class setting the PP at max
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="attributes"></param>
        /// <returns></returns>
        public MoveInstance( PokemonInstance owner, Move attributes) : this(owner, attributes, attributes.PP)
        { }
        # endregion


        # region Methods
            # region ModifyStat
        /// <summary>
        /// Modify the Stat indexed by its Enum key in the Stats List, using a modifier from -6 to +6
        /// </summary>
        /// <param name="poke">The PokemonInstance whose Stat is to modify</param>
        /// <param name="statKey">The Enum indexing the Stat to modify</param>
        /// <param name="modifier">The Modifier defining how the Stat should be modified</param>
        public void ModifyStat(PokemonInstance poke, Stat statKey, int modifier)
        {
            if (!Enum
                    .GetValues<Stat>()
                    .ToList()
                    .Contains(statKey))
                throw new ArgumentException("The Stat key is not valid");
            else
            {
                // a Modifier is an Integer that can go from -6 to +6
                poke.StatModifiers.Add(statKey, modifier);
                int pokeModifier = poke.StatModifiers.Get(statKey);

                // Check if it is still in the interval (-6; 6)
                // If not, set it back to the nearest limit value (6 or -6)
                if (pokeModifier > 6)
                    poke.StatModifiers.Set(statKey, 6);
                    pokeModifier = 6;
                if (pokeModifier < -6)
                    poke.StatModifiers.Set(statKey, -6);
                    pokeModifier = -6;

                int baseStat = poke.CalculatedStats.Get(statKey);
                // If Modifier is positive,
                if (pokeModifier > 0)
                    // it modifies the corresponding stat using the formula f(stat) = stat * (modifier + 2) / 2
                    poke.CurrentStats.Set(
                        statKey,
                        baseStat * ( (modifier + 2 ) / 2 )
                        );
                else if (pokeModifier < 0) // If Modifier is negative,
                    // it modifies the corresponding stat using the formula f(stat) = stat * 2 / ( |modifier| + 2)      | x | : absolute value of x
                    poke.CurrentStats.Set(
                        statKey,
                        poke.CalculatedStats.Get(statKey) * ( 2 / (Math.Abs(poke.StatModifiers.Get(statKey)) + 2 ) )
                        );
                else // If Modifier is 0,
                    poke.CurrentStats.Set(statKey, baseStat);
            }
        }

        /// <summary>
        /// Modify the BattleStat indexed by its Enum key in the Stats List, using a modifier from -6 to +6
        /// </summary>
        /// <param name="poke">The PokemonInstance whose Stat is to modify</param>
        /// <param name="statKey">The Enum indexing the Stat to modify</param>
        /// <param name="modifier">The Modifier defining how the Stat should be modified</param>
        public void ModifyBattleStat(PokemonInstance poke, AccuracyEvasion statKey, int modifier)
        {
            if (!Enum
                    .GetValues<AccuracyEvasion>()
                    .ToList()
                    .Contains(statKey))
                throw new ArgumentException("The Stat key is not valid");
            else
            {
                // a Modifier is an Integer that can go from -6 to +6
                poke.BattleStatModifiers!.Add(statKey, modifier);
                int pokeModifier = poke.BattleStatModifiers.Get(statKey);

                // Check if it is still in the interval (-6; 6)
                // If not, set it back to the nearest limit value (6 or -6)
                if (pokeModifier > 6)
                    poke.BattleStatModifiers.Set(statKey, 6);
                    pokeModifier = 6;
                if (pokeModifier < -6)
                    poke.BattleStatModifiers.Set(statKey, -6);
                    pokeModifier = -6;

                int baseStat = 100; // base Precision and Evasion are always 100%
                // If Modifier is positive,
                if (pokeModifier > 0)
                    // it modifies the corresponding stat using the formula f(stat) = stat * (modifier + 2) / 2
                    poke.BattleStats!.Set(
                        statKey,
                        baseStat * ( (modifier + 3 ) / 3 )
                        );
                else if (pokeModifier < 0) // If Modifier is negative,
                    // it modifies the corresponding stat using the formula f(stat) = stat * 2 / ( |modifier| + 2)      | x | : absolute value of x
                    poke.BattleStats!.Set(
                        statKey,
                        (int) Math.Floor(baseStat * ( 3.0 / (Math.Abs(poke.BattleStatModifiers.Get(statKey)) + 3 ) ))
                        );
                else // If Modifier is 0,
                    poke.BattleStats!.Set(statKey, baseStat);
            }
        }
            # endregion
            # region ModifyHP
        /// <summary>
        /// Heal the PokemonInstance the amount of the value
        /// </summary>
        /// <param name="poke"></param>
        /// <param name="value"></param>
        public void Heal(PokemonInstance poke, int value)
        {
            ModifyHP(poke, value);
            if (poke.CurrentStats.Get(Stat.HP) > poke.CalculatedStats.Get(Stat.HP))
                poke.CurrentStats.Set(Stat.HP, poke.CalculatedStats.Get(Stat.HP));
        }
        
        /// <summary>
        /// Hurt the PokemonInstance the amount of the value
        /// </summary>
        /// <param name="poke"></param>
        /// <param name="value"></param>
        public void Hurt(PokemonInstance poke, int value)
        {
            ModifyHP(poke, -value);
            if (poke.CurrentStats.Get(Stat.HP) < 0)
                poke.CurrentStats.Set(Stat.HP, 0);
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="poke">The PokemonInstance whose HP is to modify</param>
        /// <param name="modifier">How much should be added</param>
        protected void ModifyHP(PokemonInstance poke, int modifier)
        {
            poke.CurrentStats.Add(Stat.HP, modifier);
        }
            # endregion
        #endregion
    }
}