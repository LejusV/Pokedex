using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Claydol Species to store common natural stats of all Claydols
	#region SpeciesClaydol
	public class SpeciesClaydol : PokemonSpecies
	{
#nullable enable
		private static SpeciesClaydol? _instance = null;
#nullable restore
        public static SpeciesClaydol Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesClaydol();
                }
                return _instance;
            }
        }

		#region SpeciesClaydol Constructor
		public SpeciesClaydol() : base(
			"Claydol",
			1.5,
			108.0,
			60, // HPs
			70, 105, // Attack & Defense
			70, 120, // Special Attack & Defense
			75		
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
				"Hyper-Beam",
				"Strength",
				"Solar-Beam",
				"Earthquake",
				"Dig",
				"Toxic",
				"Confusion",
				"Psychic",
				"Teleport",
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
				"Rock-Smash",
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
				"Giga-Impact",
				"Zen-Headbutt",
				"Trick-Room",
				"Stone-Edge",
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

	//Claydol PokemonInstance Class
	#region Claydol
	public class ClaydolInstance : PokemonInstance
	{
		#region Claydol Constructors
		/// <summary>
		/// Claydol Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public ClaydolInstance(string nickname, int level)
		: base(
				344,
				SpeciesClaydol.Instance, // Pokemon Species
				nickname, level,
				Ground.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Claydol Builder only waiting for a Level
		/// </summary>
		public ClaydolInstance(int level)
		: base(
				344,
				SpeciesClaydol.Instance, // PokemonInstance Species
				"Claydol", level,
				Ground.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Claydol Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Claydol() : base(
			344,
			SpeciesClaydol.Instance, // PokemonInstance Species
			Ground.Instance, Psychic.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}