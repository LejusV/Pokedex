using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Turtwig Species to store common natural stats of all Turtwigs
	#region TurtwigSpecies
	public class TurtwigSpecies : PokemonSpecies
	{
#nullable enable
		private static TurtwigSpecies? _instance = null;
#nullable restore
        public static TurtwigSpecies Instance => _instance ?? (_instance = new TurtwigSpecies());

		#region TurtwigSpecies Constructor
		public TurtwigSpecies() : base(
			387,
			"Turtwig",
			Grass.Instance,
			0.4,
			10.2,
			new PokemonStats(
				55, // HPs
				68, 64, // Attack & Defense
				45, 55, // Spacial Attack & Defense
				31 // Speed
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
				"Swords-Dance",
				"Cut",
				"Headbutt",
				"Tackle",
				"Body-Slam",
				"Thrash",
				"Double-Edge",
				"Bite",
				"Strength",
				"Absorb",
				"Mega-Drain",
				"Leech-Seed",
				"Growth",
				"Razor-Leaf",
				"Solar-Beam",
				"Toxic",
				"Double-Team",
				"Withdraw",
				"Light-Screen",
				"Reflect",
				"Amnesia",
				"Flash",
				"Rest",
				"Substitute",
				"Snore",
				"Curse",
				"Protect",
				"Mud-Slap",
				"Giga-Drain",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Iron-Tail",
				"Synthesis",
				"Hidden-Power",
				"Sunny-Day",
				"Crunch",
				"Rock-Smash",
				"Stockpile",
				"Spit-Up",
				"Swallow",
				"Facade",
				"Nature-Power",
				"Superpower",
				"Secret-Power",
				"Tickle",
				"Sand-Tomb",
				"Bullet-Seed",
				"Natural-Gift",
				"Worry-Seed",
				"Seed-Bomb",
				"Energy-Ball",
				"Earth-Power",
				"Rock-Climb",
				"Leaf-Storm",
				"Captivate",
				"Stealth-Rock",
				"Grass-Knot",
				"Wide-Guard",
				"Heavy-Slam",
				"Round",
				"Grass-Pledge",
				"Work-Up",
				"Grassy-Terrain",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}