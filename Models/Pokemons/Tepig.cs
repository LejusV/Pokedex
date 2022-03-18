using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Tepig Species to store common natural stats of all Tepigs
	#region SpeciesTepig
	public class SpeciesTepig : PokemonSpecies
	{
#nullable enable
		private static SpeciesTepig? _instance = null;
#nullable restore
        public static SpeciesTepig Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesTepig();
                }
                return _instance;
            }
        }

		#region SpeciesTepig Constructor
		public SpeciesTepig() : base(
			498,
			"Tepig",
			0.5,
			9.9,
			65, // HPs
			63, 45, // Attack & Defense
			45, 45, // Special Attack & Defense
			45		
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
				"Tackle",
				"Body-Slam",
				"Take-Down",
				"Thrash",
				"Tail-Whip",
				"Roar",
				"Ember",
				"Flamethrower",
				"Strength",
				"Solar-Beam",
				"Toxic",
				"Double-Team",
				"Defense-Curl",
				"Smog",
				"Fire-Blast",
				"Rest",
				"Substitute",
				"Snore",
				"Curse",
				"Protect",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Magnitude",
				"Iron-Tail",
				"Hidden-Power",
				"Sunny-Day",
				"Rock-Smash",
				"Heat-Wave",
				"Will-O-Wisp",
				"Facade",
				"Taunt",
				"Helping-Hand",
				"Superpower",
				"Yawn",
				"Endeavor",
				"Secret-Power",
				"Overheat",
				"Odor-Sleuth",
				"Rock-Tomb",
				"Covet",
				"Gyro-Ball",
				"Assurance",
				"Sucker-Punch",
				"Flare-Blitz",
				"Zen-Headbutt",
				"Grass-Knot",
				"Head-Smash",
				"Heavy-Slam",
				"Flame-Charge",
				"Round",
				"Echoed-Voice",
				"Incinerate",
				"Fire-Pledge",
				"Work-Up",
				"Wild-Charge",
				"Heat-Crash",
				"Confide",
				"Burn-Up"
			};
		}
		#endregion
	}
	#endregion

	//Tepig PokemonInstance Class
	#region Tepig
	public class TepigInstance : PokemonInstance
	{
		#region Tepig Constructors
		/// <summary>
		/// Tepig Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public TepigInstance(string nickname, int level)
		: base(
				SpeciesTepig.Instance, // Pokemon Species
				nickname, level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tepig Builder only waiting for a Level
		/// </summary>
		public TepigInstance(int level)
		: base(
				SpeciesTepig.Instance, // PokemonInstance Species
				"Tepig", level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tepig Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public TepigInstance() : base(
			SpeciesTepig.Instance, // PokemonInstance Species
			Fire.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}