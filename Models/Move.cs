using System;
using System.Text;
using Pokedex.Enums;

namespace Pokedex.Models
{
    public abstract class Move
    {
        # region Variables
        private readonly int? _accuracy;
        private readonly MoveCategory _category;
        private readonly int _maxPp;
        private readonly string _name;
        private readonly PokeType _PokeType;
        private readonly int? _power;
        private int _pp;
        private readonly int _priority;
        # endregion

        # region Attributes
        // Values
        public int? Accuracy { get => this._accuracy; }

        public MoveCategory Category { get => this._category; }

        public int MaxPP { get => this._maxPp; }

        public string Name { get => this._name; }

        public PokeType PokeType { get => this._PokeType; }

        public int? Power { get => this._power; }

        public int PP { get => this._pp; }

        public int Priority { get => this._priority; }

        // Display Methods
        public string PPStatus
        {
            get => $"{this._name} : {this._pp}/{this._maxPp} PP";
        }
        public string FullStatus {

            get
            {
                StringBuilder output = new StringBuilder();
                // line 1
                output.AppendLine($"{this._name, -16}"); // Move Name (line 1)
                // line 2
                output.AppendLine("┌--------------┬--------------------┐");

                output.Append($"| Type: {this._PokeType.Name, 6} |"); // Move PokeType (line 2)
                output.AppendLine($" Category: {this._category, -8} |"); // Move Category (line 2)
                // line 3
                output.Append($"| Power:   {this._power?.ToString() ?? "-", 3} | "); // Move Power (line 3)
                output.AppendLine($"Accuracy: {this._accuracy?.ToString("#'%'") ?? "-", 4}     |"); // Move Accuracy (line 3)
                // line 4
                output.Append($"| PP:    {this._pp, 2}/{this._maxPp, 2} | "); // Move PP (line 4)
                output.AppendLine($"Priority: {this._priority, -2:+#;-#;0}       |"); // Move Priority (line 4)

                output.AppendLine("└--------------┴--------------------┘");

                return output.ToString(); // output
            }
        }
        # endregion

        # region Constructors
        public Move(string name, PokeType type, MoveCategory category, int maxPp, int? power, int? accuracy, int priority)
        {
            _accuracy = accuracy;
            _category = category;
            if (name != "")
                _name = name;
			else throw new ArgumentException("Name cannot be empty");
            _PokeType = type;
            _power = power; 
            _pp = _maxPp = maxPp; // initialise maxPp & set current pp to max pp
            _priority = priority;
        }
        # endregion


        # region Methods
        //public abstract void Use();

        # region ModifyStat
        /// <summary>
        /// Modify the Stat indexed by its string key in the Stats List, using a modifier from -6 to +6
        /// </summary>
        /// <param name="pokeInstance">The PokemonInstance whose Stat is to modify</param>
        /// <param name="statKey">The string indexing the Stat to modify</param>
        /// <param name="modifier">The Modifier defining how the Stat should be modified</param>
        protected void ModifyStat(PokemonInstance pokeInstance, string statKey, int modifier)
        {
            if (!PokemonStats.Keys.Contains(statKey))

            // a Modifier is an Int32 that can go from -6 to +6
            pokeInstance.StatModifiers.Add(statKey, modifier);
            int pokeModifier = pokeInstance.StatModifiers.Get(statKey);

            // Check if it is still in the interval (-6; 6)
            // If not, set it back to the nearest limit value (6 or -6)
            if (pokeModifier > 6)
                pokeInstance.StatModifiers.Set(statKey, 6);
                pokeModifier = 6;
            if (pokeModifier < -6)
                pokeInstance.StatModifiers.Set(statKey, -6);
                pokeModifier = -6;

            int baseStat = pokeInstance.CalculatedStats.Get(statKey);
            // If Modifier is positive,
            if (pokeModifier > 0)
                // it modifies the corresponding stat using the formula f(stat) = stat * (modifier + 2) / 2
                pokeInstance.CurrentStats.Set(
                    statKey,
                    baseStat * ( (modifier + 2 ) / 2 )
                    );
            else
            {
                // If Modifier is negative,
                if (pokeModifier < 0)
                    // it modifies the corresponding stat using the formula f(stat) = stat * 2 / ( |modifier| + 2)      | x | : absolute value of x
                    pokeInstance.CurrentStats.Set(
                        statKey,
                        pokeInstance.CalculatedStats.Get(statKey) * ( 2 / (Math.Abs(pokeInstance.StatModifiers.Get(statKey)) + 2 ) )
                        );
            }
        }
        # endregion

        # region ModifyStat
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pokeInstance">The PokemonInstance whose HP is to modify</param>
        /// <param name="modifier">How much should be added</param>
        protected void ModifyHP(PokemonInstance pokeInstance, int modifier)
        {
            pokeInstance.CurrentStats.Add("HP", modifier);
        }
        # endregion

        # region Heal
        /// <summary>
        /// Heal the PokemonInstance the amount of the value
        /// </summary>
        /// <param name="pokeInstance"></param>
        /// <param name="value"></param>
        protected void Heal(PokemonInstance pokeInstance, int value)
        {
            ModifyHP(pokeInstance, value);
        }
        # endregion

        # region Hurt
        /// <summary>
        /// Hurt the PokemonInstance the amount of the value
        /// </summary>
        /// <param name="pokeInstance"></param>
        /// <param name="value"></param>
        protected void Hurt(PokemonInstance pokeInstance, int value)
        {
            ModifyHP(pokeInstance, -value);
        }
        # endregion

        #endregion
    }
}