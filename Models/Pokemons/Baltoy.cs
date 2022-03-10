using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Baltoy Species to store common natural stats of all Baltoys
	#region SpeciesBaltoy
	public class SpeciesBaltoy : PokemonSpecies
	{
#nullable enable
		private static SpeciesBaltoy? _instance = null;
#nullable restore
        public static SpeciesBaltoy Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesBaltoy();
                }
                return _instance;
            }
        }

		#region SpeciesBaltoy Constructor
		public SpeciesBaltoy() : base(
			"Baltoy",
			0.5,
			21.5,
			40, // HPs
			40, 55, // Attack & Defense
			40, 70, // Special Attack & Defense
			55		
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
				"Headbutt",
				"Double-Edge",
				"Ice-Beam",
				"Psybeam",
				"Solar-Beam",
				"Earthquake",
				"Dig",
				"Toxic",
				"Confusion",
				"Psychic",
				"Mimic",
				"Double-Team",
				"Harden",
				"Light-Screen",
				"Reflect",
				"Self-Destruct",
				"Dream-Eater",
				"Flash",
				"Explosion",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Protect",
				"Mud-Slap",
				"Sandstorm",
				"Endure",
				"Swagger",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Rapid-Spin",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Ancient-Power",
				"Shadow-Ball",
				"Facade",
				"Trick",
				"Magic-Coat",
				"Recycle",
				"Skill-Swap",
				"Imprison",
				"Secret-Power",
				"Rock-Tomb",
				"Cosmic-Power",
				"Signal-Beam",
				"Extrasensory",
				"Calm-Mind",
				"Gravity",
				"Gyro-Ball",
				"Natural-Gift",
				"Heal-Block",
				"Power-Trick",
				"Rock-Polish",
				"Earth-Power",
				"Zen-Headbutt",
				"Trick-Room",
				"Stealth-Rock",
				"Grass-Knot",
				"Charge-Beam",
				"Guard-Split",
				"Power-Split",
				"Wonder-Room",
				"Psyshock",
				"Telekinesis",
				"Smack-Down",
				"Round",
				"Ally-Switch",
				"Bulldoze",
				"Drill-Run",
				"Confide",
				"Dazzling-Gleam"
			};
		}
		#endregion
	}
	#endregion

	//Baltoy PokemonInstance Class
	#region Baltoy
	public class BaltoyInstance : PokemonInstance
	{
		#region Baltoy Constructors
		/// <summary>
		/// Baltoy Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public BaltoyInstance(string nickname, int level)
		: base(
				343,
				SpeciesBaltoy.Instance, // Pokemon Species
				nickname, level,
				Ground.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Baltoy Builder only waiting for a Level
		/// </summary>
		public BaltoyInstance(int level)
		: base(
				343,
				SpeciesBaltoy.Instance, // PokemonInstance Species
				"Baltoy", level,
				Ground.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Baltoy Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Baltoy() : base(
			343,
			SpeciesBaltoy.Instance, // PokemonInstance Species
			Ground.Instance, Psychic.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}