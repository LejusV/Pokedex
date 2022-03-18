using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Corsola Species to store common natural stats of all Corsolas
	#region SpeciesCorsola
	public class SpeciesCorsola : PokemonSpecies
	{
#nullable enable
		private static SpeciesCorsola? _instance = null;
#nullable restore
        public static SpeciesCorsola Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesCorsola();
                }
                return _instance;
            }
        }

		#region SpeciesCorsola Constructor
		public SpeciesCorsola() : base(
			222,
			"Corsola",
			0.6,
			5.0,
			65, // HPs
			55, 95, // Attack & Defense
			65, 95, // Special Attack & Defense
			35		
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
				"Tackle",
				"Body-Slam",
				"Double-Edge",
				"Mist",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Bubble-Beam",
				"Strength",
				"Earthquake",
				"Dig",
				"Toxic",
				"Psychic",
				"Mimic",
				"Screech",
				"Double-Team",
				"Recover",
				"Harden",
				"Confuse-Ray",
				"Defense-Curl",
				"Barrier",
				"Light-Screen",
				"Reflect",
				"Bide",
				"Self-Destruct",
				"Spike-Cannon",
				"Amnesia",
				"Bubble",
				"Explosion",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Curse",
				"Flail",
				"Protect",
				"Mud-Slap",
				"Icy-Wind",
				"Sandstorm",
				"Endure",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Mirror-Coat",
				"Ancient-Power",
				"Shadow-Ball",
				"Rock-Smash",
				"Whirlpool",
				"Hail",
				"Facade",
				"Nature-Power",
				"Ingrain",
				"Magic-Coat",
				"Endeavor",
				"Refresh",
				"Secret-Power",
				"Camouflage",
				"Rock-Tomb",
				"Icicle-Spear",
				"Iron-Defense",
				"Calm-Mind",
				"Rock-Blast",
				"Water-Pulse",
				"Brine",
				"Natural-Gift",
				"Lucky-Chant",
				"Sucker-Punch",
				"Aqua-Ring",
				"Rock-Polish",
				"Power-Gem",
				"Earth-Power",
				"Stone-Edge",
				"Captivate",
				"Stealth-Rock",
				"Head-Smash",
				"Round",
				"Scald",
				"Bulldoze",
				"Confide",
				"Liquidation"
			};
		}
		#endregion
	}
	#endregion

	//Corsola PokemonInstance Class
	#region Corsola
	public class CorsolaInstance : PokemonInstance
	{
		#region Corsola Constructors
		/// <summary>
		/// Corsola Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public CorsolaInstance(string nickname, int level)
		: base(
				SpeciesCorsola.Instance, // Pokemon Species
				nickname, level,
				Water.Instance, Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Corsola Builder only waiting for a Level
		/// </summary>
		public CorsolaInstance(int level)
		: base(
				SpeciesCorsola.Instance, // PokemonInstance Species
				"Corsola", level,
				Water.Instance, Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Corsola Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public CorsolaInstance() : base(
			SpeciesCorsola.Instance, // PokemonInstance Species
			Water.Instance, Rock.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}