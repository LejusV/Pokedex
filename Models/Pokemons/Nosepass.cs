using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Nosepass Species to store common natural stats of all Nosepasss
	#region SpeciesNosepass
	public class SpeciesNosepass : PokemonSpecies
	{
#nullable enable
		private static SpeciesNosepass? _instance = null;
#nullable restore
        public static SpeciesNosepass Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesNosepass();
                }
                return _instance;
            }
        }

		#region SpeciesNosepass Constructor
		public SpeciesNosepass() : base(
			299,
			"Nosepass",
			1.0,
			97.0,
			30, // HPs
			45, 135, // Attack & Defense
			45, 90, // Special Attack & Defense
			30		
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
				"Tackle",
				"Body-Slam",
				"Double-Edge",
				"Strength",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Rock-Throw",
				"Earthquake",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Harden",
				"Defense-Curl",
				"Self-Destruct",
				"Explosion",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Protect",
				"Mud-Slap",
				"Zap-Cannon",
				"Lock-On",
				"Sandstorm",
				"Endure",
				"Rollout",
				"Swagger",
				"Spark",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pain-Split",
				"Magnitude",
				"Dynamic-Punch",
				"Hidden-Power",
				"Sunny-Day",
				"Ancient-Power",
				"Rock-Smash",
				"Torment",
				"Facade",
				"Taunt",
				"Magic-Coat",
				"Secret-Power",
				"Rock-Tomb",
				"Iron-Defense",
				"Block",
				"Rock-Blast",
				"Shock-Wave",
				"Gravity",
				"Natural-Gift",
				"Magnet-Rise",
				"Rock-Polish",
				"Power-Gem",
				"Earth-Power",
				"Discharge",
				"Stone-Edge",
				"Captivate",
				"Stealth-Rock",
				"Head-Smash",
				"Wide-Guard",
				"Smack-Down",
				"Round",
				"Volt-Switch",
				"Bulldoze",
				"Confide",
				"Dazzling-Gleam"
			};
		}
		#endregion
	}
	#endregion

	//Nosepass PokemonInstance Class
	#region Nosepass
	public class NosepassInstance : PokemonInstance
	{
		#region Nosepass Constructors
		/// <summary>
		/// Nosepass Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public NosepassInstance(string nickname, int level)
		: base(
				SpeciesNosepass.Instance, // Pokemon Species
				nickname, level,
				Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Nosepass Builder only waiting for a Level
		/// </summary>
		public NosepassInstance(int level)
		: base(
				SpeciesNosepass.Instance, // PokemonInstance Species
				"Nosepass", level,
				Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Nosepass Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public NosepassInstance() : base(
			SpeciesNosepass.Instance, // PokemonInstance Species
			Rock.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}