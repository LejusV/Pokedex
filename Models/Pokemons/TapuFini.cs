using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Tapu-Fini Species to store common natural stats of all Tapu-Finis
	#region SpeciesTapu-Fini
	public class SpeciesTapuFini : PokemonSpecies
	{
#nullable enable
		private static SpeciesTapuFini? _instance = null;
#nullable restore
        public static SpeciesTapuFini Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesTapuFini();
                }
                return _instance;
            }
        }

		#region SpeciesTapu-Fini Constructor
		public SpeciesTapuFini() : base(
			788,
			"Tapu-Fini",
			1.3,
			21.2,
			70, // HPs
			75, 115, // Attack & Defense
			95, 130, // Special Attack & Defense
			85		
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
				"Mist",
				"Water-Gun",
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Hyper-Beam",
				"Toxic",
				"Double-Team",
				"Withdraw",
				"Light-Screen",
				"Haze",
				"Reflect",
				"Waterfall",
				"Substitute",
				"Protect",
				"Swagger",
				"Mean-Look",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Hidden-Power",
				"Rain-Dance",
				"Psych-Up",
				"Shadow-Ball",
				"Whirlpool",
				"Torment",
				"Facade",
				"Nature-Power",
				"Taunt",
				"Refresh",
				"Muddy-Water",
				"Calm-Mind",
				"Water-Pulse",
				"Brine",
				"Fling",
				"Aqua-Ring",
				"Giga-Impact",
				"Defog",
				"Grass-Knot",
				"Soak",
				"Round",
				"Echoed-Voice",
				"Scald",
				"Heal-Pulse",
				"Misty-Terrain",
				"Moonblast",
				"Confide",
				"Dazzling-Gleam",
				"Smart-Strike",
				"Natures-Madness"
			};
		}
		#endregion
	}
	#endregion

	//Tapu-Fini PokemonInstance Class
	#region Tapu-Fini
	public class TapuFiniInstance : PokemonInstance
	{
		#region Tapu-Fini Constructors
		/// <summary>
		/// Tapu-Fini Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public TapuFiniInstance(string nickname, int level)
		: base(
				SpeciesTapuFini.Instance, // Pokemon Species
				nickname, level,
				Water.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tapu-Fini Builder only waiting for a Level
		/// </summary>
		public TapuFiniInstance(int level)
		: base(
				SpeciesTapuFini.Instance, // PokemonInstance Species
				"Tapu-Fini", level,
				Water.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tapu-Fini Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public TapuFiniInstance() : base(
			SpeciesTapuFini.Instance, // PokemonInstance Species
			Water.Instance, Fairy.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}