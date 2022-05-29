using System;
using System.Collections.Generic;
using System.Text;
using Pokedex.Enums;

// A COMMENTER
namespace Pokedex.Models
{
    public abstract class Move
    {
        # region Variables
        private readonly int? _accuracy;
        private readonly MoveAilment? _ailment;
        private readonly DamageCategory _damageCat;
        private readonly string _description;
        private readonly int _healingPercent;
        private readonly MoveCategory _mvCat;
        private readonly string _name;
        private readonly int? _power;
        private int _pp;
        private readonly int _priority;
        private readonly Dictionary<Enums.BattleStat, int>? _statChanges;
        private readonly MoveTarget _targetType;
        private readonly PokemonType _type;
        # endregion

        # region Attributes
            # region Getters
        // Values
        public int? Accuracy => this._accuracy;
        public MoveAilment? Ailment => this._ailment;
        public DamageCategory DamageCategory => this._damageCat;
        public string Description => this._description;
        public int HealingPercent => this._healingPercent;
        public MoveCategory MoveCategory => this._mvCat;
        public string Name => this._name;
        public PokemonType Type => this._type;
        public int? Power => this._power;
        public int PP => this._pp;
        public Dictionary<Enums.BattleStat, int>? StatChanges => this._statChanges;
        public int Priority => this._priority;
        public MoveTarget TargetType => this._targetType;
            # endregion
            #region String Getters
        public string FullStatus {

            get
            {
                StringBuilder output = new StringBuilder();
                // line 1
                output.AppendLine($"{this._name, -16}"); // Move Name (line 1)
                // line 2
                output.AppendLine("┌--------------┬--------------------┐");

                output.Append($"| Type: {this._type.Name, 6} |"); // Move PokemonType (line 2)
                output.AppendLine($" Category: {this._damageCat, -8} |"); // Move Category (line 2)
                // line 3
                output.Append($"| Power:   {this._power?.ToString() ?? "-", 3} | "); // Move Power (line 3)
                output.AppendLine($"Accuracy: {this._accuracy?.ToString("#'%'") ?? "-", 4}     |"); // Move Accuracy (line 3)
                // line 4
                output.Append($"| PP:    {this._pp, 2}    | "); // Move PP (line 4)
                output.AppendLine($"Priority: {this._priority, -2:+#;-#;0}       |"); // Move Priority (line 4)

                output.AppendLine("└--------------┴--------------------┘");

                return output.ToString(); // output
            }
        }
            #endregion
        # endregion

        # region Constructors
        public Move(int? accuracy, MoveAilment? ailment, DamageCategory damageCat, string description, int healingPercent, MoveCategory mvCat, string name, int? power, int pp, int priority, Dictionary<Enums.BattleStat,int>? statChanges, MoveTarget targetType, PokemonType type)
        {
            this._accuracy = accuracy;
            this._ailment = ailment;
            this._damageCat = damageCat;
            this._description = description;
            this._healingPercent = healingPercent;
            this._mvCat = mvCat;
            if (name != "")
                this._name = name;
			else throw new ArgumentException("Name cannot be empty");
            this._power = power; 
            this._pp = pp;
            this._priority = priority;
            this._statChanges = statChanges;
            this._targetType = targetType;
            this._type = type;
        }
        # endregion
    }
}// A COMMENTER