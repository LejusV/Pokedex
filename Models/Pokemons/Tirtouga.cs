using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Tirtouga Species to store common natural stats of all Tirtougas
	#region SpeciesTirtouga
	public class SpeciesTirtouga : PokemonSpecies
	{
#nullable enable
		private static SpeciesTirtouga? _instance = null;
#nullable restore
        public static SpeciesTirtouga Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesTirtouga();
                }
                return _instance;
            }
        }

		#region SpeciesTirtouga Constructor
		public SpeciesTirtouga() : base(
			"Tirtouga",
			0.7,
			16.5,
			54, // HPs
			78, 103, // Attack & Defense
			53, 45, // Special Attack & Defense
			22		
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
				"Slam",
				"Body-Slam",
				"Bite",
				"Water-Gun",
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Strength",
				"Rock-Throw",
				"Earthquake",
				"Dig",
				"Toxic",
				"Double-Team",
				"Withdraw",
				"Bide",
				"Waterfall",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Curse",
				"Flail",
				"Protect",
				"Icy-Wind",
				"Sandstorm",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Crunch",
				"Ancient-Power",
				"Rock-Smash",
				"Whirlpool",
				"Facade",
				"Knock-Off",
				"Secret-Power",
				"Dive",
				"Rock-Tomb",
				"Iron-Defense",
				"Block",
				"Water-Pulse",
				"Brine",
				"Guard-Swap",
				"Rock-Polish",
				"Aqua-Tail",
				"Earth-Power",
				"Zen-Headbutt",
				"Stone-Edge",
				"Stealth-Rock",
				"Aqua-Jet",
				"Wide-Guard",
				"Smack-Down",
				"Round",
				"Scald",
				"Shell-Smash",
				"Bulldoze",
				"Confide",
				"Liquidation"
			};
		}
		#endregion
	}
	#endregion

	//Tirtouga PokemonInstance Class
	#region Tirtouga
	public class TirtougaInstance : PokemonInstance
	{
		#region Tirtouga Constructors
		/// <summary>
		/// Tirtouga Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public TirtougaInstance(string nickname, int level)
		: base(
				564,
				SpeciesTirtouga.Instance, // Pokemon Species
				nickname, level,
				Water.Instance, Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tirtouga Builder only waiting for a Level
		/// </summary>
		public TirtougaInstance(int level)
		: base(
				564,
				SpeciesTirtouga.Instance, // PokemonInstance Species
				"Tirtouga", level,
				Water.Instance, Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tirtouga Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Tirtouga() : base(
			564,
			SpeciesTirtouga.Instance, // PokemonInstance Species
			Water.Instance, Rock.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}