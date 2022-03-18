using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Seedot Species to store common natural stats of all Seedots
	#region SpeciesSeedot
	public class SpeciesSeedot : PokemonSpecies
	{
#nullable enable
		private static SpeciesSeedot? _instance = null;
#nullable restore
        public static SpeciesSeedot Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesSeedot();
                }
                return _instance;
            }
        }

		#region SpeciesSeedot Constructor
		public SpeciesSeedot() : base(
			273,
			"Seedot",
			0.5,
			4.0,
			40, // HPs
			40, 50, // Attack & Defense
			30, 30, // Special Attack & Defense
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
				"Razor-Wind",
				"Swords-Dance",
				"Headbutt",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Leech-Seed",
				"Growth",
				"Solar-Beam",
				"Dig",
				"Toxic",
				"Quick-Attack",
				"Mimic",
				"Double-Team",
				"Harden",
				"Defense-Curl",
				"Bide",
				"Self-Destruct",
				"Amnesia",
				"Flash",
				"Explosion",
				"Rest",
				"Substitute",
				"Snore",
				"Spite",
				"Protect",
				"Giga-Drain",
				"Endure",
				"Rollout",
				"False-Swipe",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Synthesis",
				"Hidden-Power",
				"Sunny-Day",
				"Shadow-Ball",
				"Rock-Smash",
				"Beat-Up",
				"Facade",
				"Nature-Power",
				"Secret-Power",
				"Bullet-Seed",
				"Natural-Gift",
				"Power-Swap",
				"Worry-Seed",
				"Seed-Bomb",
				"Energy-Ball",
				"Nasty-Plot",
				"Defog",
				"Captivate",
				"Grass-Knot",
				"Foul-Play",
				"Round",
				"Retaliate",
				"Grassy-Terrain",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Seedot PokemonInstance Class
	#region Seedot
	public class SeedotInstance : PokemonInstance
	{
		#region Seedot Constructors
		/// <summary>
		/// Seedot Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public SeedotInstance(string nickname, int level)
		: base(
				SpeciesSeedot.Instance, // Pokemon Species
				nickname, level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Seedot Builder only waiting for a Level
		/// </summary>
		public SeedotInstance(int level)
		: base(
				SpeciesSeedot.Instance, // PokemonInstance Species
				"Seedot", level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Seedot Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public SeedotInstance() : base(
			SpeciesSeedot.Instance, // PokemonInstance Species
			Grass.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}