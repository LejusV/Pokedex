using System;
using System.Text;
using Pokedex.Enums;

namespace Pokedex.Models
{
    public abstract class MoveInstance
    {
        # region Variables
        # endregion

        # region Attributes
        // Values
        public Move Attributes { get; }
        public PokemonInstance Owner { get; }
        public int PP { get; }

        // Display Methods
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
                output.AppendLine($" Category: {this.Attributes.Category, -8} |"); // Move Category (line 2)
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
        # endregion

        # region Constructors
        public MoveInstance( PokemonInstance owner, Move attributes, int pp )
        {
            this.Attributes = attributes;
            this.Owner = owner;
            this.PP = pp;

            this.Owner.LearnMove(this);
        }

        public MoveInstance( PokemonInstance owner, Move attributes) : this(owner, attributes, attributes.PP)
        { }
        # endregion


        # region Methods
        //public abstract void Use();

        # region ModifyStat
        /// <summary>
        /// Modify the Stat indexed by its string key in the Stats List, using a modifier from -6 to +6
        /// </summary>
        /// <param name="poke">The PokemonInstance whose Stat is to modify</param>
        /// <param name="statKey">The string indexing the Stat to modify</param>
        /// <param name="modifier">The Modifier defining how the Stat should be modified</param>
        protected void ModifyStat(PokemonInstance poke, string statKey, int modifier)
        {
            if (!PokemonStats.Keys.Contains(statKey))

            // a Modifier is an Int32 that can go from -6 to +6
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
            else
            {
                // If Modifier is negative,
                if (pokeModifier < 0)
                    // it modifies the corresponding stat using the formula f(stat) = stat * 2 / ( |modifier| + 2)      | x | : absolute value of x
                    poke.CurrentStats.Set(
                        statKey,
                        poke.CalculatedStats.Get(statKey) * ( 2 / (Math.Abs(poke.StatModifiers.Get(statKey)) + 2 ) )
                        );
            }
        }
        # endregion

        # region ModifyStat
        /// <summary>
        /// 
        /// </summary>
        /// <param name="poke">The PokemonInstance whose HP is to modify</param>
        /// <param name="modifier">How much should be added</param>
        protected void ModifyHP(PokemonInstance poke, int modifier)
        {
            poke.CurrentStats.Add("HP", modifier);
        }
        # endregion

        # region Heal
        /// <summary>
        /// Heal the PokemonInstance the amount of the value
        /// </summary>
        /// <param name="poke"></param>
        /// <param name="value"></param>
        protected void Heal(PokemonInstance poke, int value)
        {
            ModifyHP(poke, value);
        }
        # endregion

        # region Hurt
        /// <summary>
        /// Hurt the PokemonInstance the amount of the value
        /// </summary>
        /// <param name="poke"></param>
        /// <param name="value"></param>
        protected void Hurt(PokemonInstance poke, int value)
        {
            ModifyHP(poke, -value);
        }
        # endregion

        #endregion
    }
}