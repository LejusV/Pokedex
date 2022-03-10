using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Wailmer Species to store common natural stats of all Wailmers
	#region SpeciesWailmer
	public class SpeciesWailmer : PokemonSpecies
	{
#nullable enable
		private static SpeciesWailmer? _instance = null;
#nullable restore
        public static SpeciesWailmer Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesWailmer();
                }
                return _instance;
            }
        }

		#region SpeciesWailmer Constructor
		public SpeciesWailmer() : base(
			"Wailmer",
			2.0,
			130.0,
			130, // HPs
			70, 35, // Attack & Defense
			70, 35, // Special Attack & Defense
			60		
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
				"Body-Slam",
				"Thrash",
				"Double-Edge",
				"Growl",
				"Roar",
				"Mist",
				"Water-Gun",
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Strength",
				"Earthquake",
				"Fissure",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Defense-Curl",
				"Self-Destruct",
				"Waterfall",
				"Amnesia",
				"Splash",
				"Rest",
				"Substitute",
				"Snore",
				"Curse",
				"Protect",
				"Icy-Wind",
				"Endure",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Rain-Dance",
				"Rock-Smash",
				"Whirlpool",
				"Hail",
				"Facade",
				"Secret-Power",
				"Dive",
				"Hyper-Voice",
				"Astonish",
				"Rock-Tomb",
				"Tickle",
				"Water-Spout",
				"Bounce",
				"Water-Pulse",
				"Brine",
				"Natural-Gift",
				"Aqua-Ring",
				"Avalanche",
				"Zen-Headbutt",
				"Captivate",
				"Heavy-Slam",
				"Soak",
				"Round",
				"Echoed-Voice",
				"Clear-Smog",
				"Scald",
				"Bulldoze",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Wailmer PokemonInstance Class
	#region Wailmer
	public class WailmerInstance : PokemonInstance
	{
		#region Wailmer Constructors
		/// <summary>
		/// Wailmer Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public WailmerInstance(string nickname, int level)
		: base(
				320,
				SpeciesWailmer.Instance, // Pokemon Species
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Wailmer Builder only waiting for a Level
		/// </summary>
		public WailmerInstance(int level)
		: base(
				320,
				SpeciesWailmer.Instance, // PokemonInstance Species
				"Wailmer", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Wailmer Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Wailmer() : base(
			320,
			SpeciesWailmer.Instance, // PokemonInstance Species
			Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}