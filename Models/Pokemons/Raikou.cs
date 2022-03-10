using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Raikou Species to store common natural stats of all Raikous
	#region SpeciesRaikou
	public class SpeciesRaikou : PokemonSpecies
	{
#nullable enable
		private static SpeciesRaikou? _instance = null;
#nullable restore
        public static SpeciesRaikou Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesRaikou();
                }
                return _instance;
            }
        }

		#region SpeciesRaikou Constructor
		public SpeciesRaikou() : base(
			"Raikou",
			1.9,
			178.0,
			90, // HPs
			85, 75, // Attack & Defense
			115, 100, // Special Attack & Defense
			115		
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
				"Cut",
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Leer",
				"Bite",
				"Roar",
				"Hyper-Beam",
				"Strength",
				"Thunder-Shock",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Dig",
				"Toxic",
				"Quick-Attack",
				"Mimic",
				"Double-Team",
				"Light-Screen",
				"Reflect",
				"Swift",
				"Flash",
				"Rest",
				"Substitute",
				"Snore",
				"Curse",
				"Protect",
				"Mud-Slap",
				"Zap-Cannon",
				"Detect",
				"Sandstorm",
				"Endure",
				"Swagger",
				"Spark",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Crunch",
				"Psych-Up",
				"Shadow-Ball",
				"Rock-Smash",
				"Facade",
				"Secret-Power",
				"Signal-Beam",
				"Extrasensory",
				"Calm-Mind",
				"Shock-Wave",
				"Natural-Gift",
				"Magnet-Rise",
				"Giga-Impact",
				"Thunder-Fang",
				"Rock-Climb",
				"Discharge",
				"Iron-Head",
				"Charge-Beam",
				"Round",
				"Quash",
				"Volt-Switch",
				"Bulldoze",
				"Wild-Charge",
				"Snarl",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Raikou PokemonInstance Class
	#region Raikou
	public class RaikouInstance : PokemonInstance
	{
		#region Raikou Constructors
		/// <summary>
		/// Raikou Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public RaikouInstance(string nickname, int level)
		: base(
				243,
				SpeciesRaikou.Instance, // Pokemon Species
				nickname, level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Raikou Builder only waiting for a Level
		/// </summary>
		public RaikouInstance(int level)
		: base(
				243,
				SpeciesRaikou.Instance, // PokemonInstance Species
				"Raikou", level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Raikou Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Raikou() : base(
			243,
			SpeciesRaikou.Instance, // PokemonInstance Species
			Electric.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}