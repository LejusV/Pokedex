using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Mesprit Species to store common natural stats of all Mesprits
	#region SpeciesMesprit
	public class SpeciesMesprit : PokemonSpecies
	{
#nullable enable
		private static SpeciesMesprit? _instance = null;
#nullable restore
        public static SpeciesMesprit Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesMesprit();
                }
                return _instance;
            }
        }

		#region SpeciesMesprit Constructor
		public SpeciesMesprit() : base(
			481,
			"Mesprit",
			0.3,
			0.3,
			80, // HPs
			105, 105, // Attack & Defense
			105, 105, // Special Attack & Defense
			80		
		)
		{
			InitMovesList();
		}
		#endregion

		#region Methods
		private void InitMovesList()
		{
			_moveList = new List<string>()
			{
				"Fire-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Headbutt",
				"Ice-Beam",
				"Blizzard",
				"Hyper-Beam",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Toxic",
				"Confusion",
				"Psychic",
				"Double-Team",
				"Light-Screen",
				"Reflect",
				"Swift",
				"Dream-Eater",
				"Flash",
				"Rest",
				"Substitute",
				"Snore",
				"Protect",
				"Mud-Slap",
				"Sandstorm",
				"Endure",
				"Charm",
				"Swagger",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Future-Sight",
				"Facade",
				"Helping-Hand",
				"Trick",
				"Role-Play",
				"Magic-Coat",
				"Recycle",
				"Knock-Off",
				"Skill-Swap",
				"Imprison",
				"Secret-Power",
				"Signal-Beam",
				"Extrasensory",
				"Calm-Mind",
				"Shock-Wave",
				"Water-Pulse",
				"Healing-Wish",
				"Natural-Gift",
				"U-Turn",
				"Fling",
				"Lucky-Chant",
				"Copycat",
				"Energy-Ball",
				"Giga-Impact",
				"Zen-Headbutt",
				"Trick-Room",
				"Stealth-Rock",
				"Grass-Knot",
				"Charge-Beam",
				"Wonder-Room",
				"Psyshock",
				"Telekinesis",
				"Magic-Room",
				"Round",
				"Acrobatics",
				"Confide",
				"Dazzling-Gleam",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion

	//Mesprit PokemonInstance Class
	#region Mesprit
	public class MespritInstance : PokemonInstance
	{
		#region Mesprit Constructors
		/// <summary>
		/// Mesprit Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public MespritInstance(string nickname, int level)
		: base(
				SpeciesMesprit.Instance, // Pokemon Species
				nickname, level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mesprit Builder only waiting for a Level
		/// </summary>
		public MespritInstance(int level)
		: base(
				SpeciesMesprit.Instance, // PokemonInstance Species
				"Mesprit", level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mesprit Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public MespritInstance() : base(
			SpeciesMesprit.Instance, // PokemonInstance Species
			Psychic.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}