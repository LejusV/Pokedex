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
        private readonly PokemonType _pokemonType;
        private readonly int? _power;
        private readonly int _pp;
        private readonly int _priority;
        # endregion

        # region Attributes
        // Values
        public int? Accuracy { get => this._accuracy; }

        public MoveCategory Category { get => this._category; }

        public int MaxPP { get => this._maxPp; }

        public string Name { get => this._name; }

        public PokemonType PokemonType { get => this._pokemonType; }

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

                output.Append($"| Type: {this._pokemonType.Name, 6} |"); // Move PokemonType (line 2)
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
        public Move(string name, PokemonType type, MoveCategory category, int maxPp, int? power, int? accuracy, int priority)
        {
            _accuracy = accuracy;
            _category = category;
            if (name != "")
                _name = name;
			else throw new ArgumentException("Name cannot be empty");
            _pokemonType = type;
            _power = power; 
            _pp = _maxPp = maxPp; // initialise maxPp & set current pp to max pp
            _priority = priority;
        }
        # endregion

        /*
        # region Methods
        public abstract void Use();
        #endregion
        */
    }
}