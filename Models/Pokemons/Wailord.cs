using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Wailord Species to store common natural stats of all Wailords
	#region SpeciesWailord
	public class SpeciesWailord : PokemonSpecies
	{
#nullable enable
		private static SpeciesWailord? _instance = null;
#nullable restore
        public static SpeciesWailord Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesWailord();
                }
                return _instance;
            }
        }

		#region SpeciesWailord Constructor
		public SpeciesWailord() : base(
			"Wailord",
			14.5,
			398.0,
			170, // HPs
			90, 45, // Attack & Defense
			90, 45, // Special Attack & Defense
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
				"Double-Edge",
				"Growl",
				"Roar",
				"Mist",
				"Water-Gun",
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Hyper-Beam",
				"Strength",
				"Earthquake",
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
				"Water-Spout",
				"Block",
				"Bounce",
				"Water-Pulse",
				"Brine",
				"Natural-Gift",
				"Giga-Impact",
				"Avalanche",
				"Zen-Headbutt",
				"Iron-Head",
				"Captivate",
				"Heavy-Slam",
				"Soak",
				"Round",
				"Echoed-Voice",
				"Scald",
				"Bulldoze",
				"Noble-Roar",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Wailord PokemonInstance Class
	#region Wailord
	public class WailordInstance : PokemonInstance
	{
		#region Wailord Constructors
		/// <summary>
		/// Wailord Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public WailordInstance(string nickname, int level)
		: base(
				321,
				SpeciesWailord.Instance, // Pokemon Species
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Wailord Builder only waiting for a Level
		/// </summary>
		public WailordInstance(int level)
		: base(
				321,
				SpeciesWailord.Instance, // PokemonInstance Species
				"Wailord", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Wailord Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Wailord() : base(
			321,
			SpeciesWailord.Instance, // PokemonInstance Species
			Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}