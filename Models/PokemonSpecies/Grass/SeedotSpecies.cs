using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Seedot Species to store common natural stats of all Seedots
	#region SeedotSpecies
	public class SeedotSpecies : PokemonSpecies
	{
#nullable enable
		private static SeedotSpecies? _instance = null;
#nullable restore
        public static SeedotSpecies Instance => _instance ?? (_instance = new SeedotSpecies());

		#region SeedotSpecies Constructor
		public SeedotSpecies() : base(
			273,
			"Seedot",
			Grass.Instance,
			0.5,
			4.0,
			new PokemonStats(
				40, // HPs
				40, 50, // Attack & Defense
				30, 30, // Spacial Attack & Defense
				30 // Speed
			)			
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
}