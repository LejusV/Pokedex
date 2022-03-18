using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Tapu-Bulu Species to store common natural stats of all Tapu-Bulus
	#region SpeciesTapu-Bulu
	public class SpeciesTapuBulu : PokemonSpecies
	{
#nullable enable
		private static SpeciesTapuBulu? _instance = null;
#nullable restore
        public static SpeciesTapuBulu Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesTapuBulu();
                }
                return _instance;
            }
        }

		#region SpeciesTapu-Bulu Constructor
		public SpeciesTapuBulu() : base(
			787,
			"Tapu-Bulu",
			1.9,
			45.5,
			70, // HPs
			130, 115, // Attack & Defense
			85, 95, // Special Attack & Defense
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
				"Swords-Dance",
				"Whirlwind",
				"Horn-Attack",
				"Roar",
				"Disable",
				"Hyper-Beam",
				"Leech-Seed",
				"Solar-Beam",
				"Toxic",
				"Withdraw",
				"Light-Screen",
				"Reflect",
				"Skull-Bash",
				"Rock-Slide",
				"Substitute",
				"Protect",
				"Scary-Face",
				"Giga-Drain",
				"False-Swipe",
				"Swagger",
				"Mean-Look",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Megahorn",
				"Hidden-Power",
				"Sunny-Day",
				"Psych-Up",
				"Torment",
				"Facade",
				"Nature-Power",
				"Taunt",
				"Superpower",
				"Brick-Break",
				"Rock-Tomb",
				"Bulk-Up",
				"Calm-Mind",
				"Payback",
				"Fling",
				"Focus-Blast",
				"Energy-Ball",
				"Giga-Impact",
				"Zen-Headbutt",
				"Stone-Edge",
				"Grass-Knot",
				"Wood-Hammer",
				"Round",
				"Echoed-Voice",
				"Work-Up",
				"Horn-Leech",
				"Snarl",
				"Rototiller",
				"Grassy-Terrain",
				"Confide",
				"Dazzling-Gleam",
				"Leafage",
				"Smart-Strike",
				"Brutal-Swing",
				"Natures-Madness"
			};
		}
		#endregion
	}
	#endregion

	//Tapu-Bulu PokemonInstance Class
	#region Tapu-Bulu
	public class TapuBuluInstance : PokemonInstance
	{
		#region Tapu-Bulu Constructors
		/// <summary>
		/// Tapu-Bulu Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public TapuBuluInstance(string nickname, int level)
		: base(
				SpeciesTapuBulu.Instance, // Pokemon Species
				nickname, level,
				Grass.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tapu-Bulu Builder only waiting for a Level
		/// </summary>
		public TapuBuluInstance(int level)
		: base(
				SpeciesTapuBulu.Instance, // PokemonInstance Species
				"Tapu-Bulu", level,
				Grass.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tapu-Bulu Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public TapuBuluInstance() : base(
			SpeciesTapuBulu.Instance, // PokemonInstance Species
			Grass.Instance, Fairy.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}