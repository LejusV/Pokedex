using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Chandelure Species to store common natural stats of all Chandelures
	#region SpeciesChandelure
	public class SpeciesChandelure : PokemonSpecies
	{
#nullable enable
		private static SpeciesChandelure? _instance = null;
#nullable restore
        public static SpeciesChandelure Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesChandelure();
                }
                return _instance;
            }
        }

		#region SpeciesChandelure Constructor
		public SpeciesChandelure() : base(
			609,
			"Chandelure",
			1.0,
			34.3,
			60, // HPs
			55, 90, // Attack & Defense
			145, 90, // Special Attack & Defense
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
				"Flamethrower",
				"Hyper-Beam",
				"Solar-Beam",
				"Toxic",
				"Psychic",
				"Double-Team",
				"Confuse-Ray",
				"Smog",
				"Fire-Blast",
				"Dream-Eater",
				"Flash",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Spite",
				"Protect",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Pain-Split",
				"Hidden-Power",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Heat-Wave",
				"Will-O-Wisp",
				"Facade",
				"Taunt",
				"Trick",
				"Secret-Power",
				"Overheat",
				"Calm-Mind",
				"Shock-Wave",
				"Payback",
				"Embargo",
				"Dark-Pulse",
				"Energy-Ball",
				"Giga-Impact",
				"Trick-Room",
				"Telekinesis",
				"Flame-Burst",
				"Flame-Charge",
				"Round",
				"Hex",
				"Incinerate",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Chandelure PokemonInstance Class
	#region Chandelure
	public class ChandelureInstance : PokemonInstance
	{
		#region Chandelure Constructors
		/// <summary>
		/// Chandelure Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public ChandelureInstance(string nickname, int level)
		: base(
				SpeciesChandelure.Instance, // Pokemon Species
				nickname, level,
				Ghost.Instance, Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Chandelure Builder only waiting for a Level
		/// </summary>
		public ChandelureInstance(int level)
		: base(
				SpeciesChandelure.Instance, // PokemonInstance Species
				"Chandelure", level,
				Ghost.Instance, Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Chandelure Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public ChandelureInstance() : base(
			SpeciesChandelure.Instance, // PokemonInstance Species
			Ghost.Instance, Fire.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}