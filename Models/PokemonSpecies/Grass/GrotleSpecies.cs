using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Grotle Species to store common natural stats of all Grotles
	#region GrotleSpecies
	public class GrotleSpecies : PokemonSpecies
	{
#nullable enable
		private static GrotleSpecies? _instance = null;
#nullable restore
        public static GrotleSpecies Instance => _instance ?? (_instance = new GrotleSpecies());

		#region GrotleSpecies Constructor
		public GrotleSpecies() : base(
			388,
			"Grotle",
			Grass.Instance,
			1.1,
			97.0,
			new PokemonStats(
				75, // HPs
				89, 85, // Attack & Defense
				55, 65, // Spacial Attack & Defense
				36 // Speed
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
				"Bite",
				"Strength",
				"Absorb",
				"Mega-Drain",
				"Leech-Seed",
				"Razor-Leaf",
				"Solar-Beam",
				"Toxic",
				"Double-Team",
				"Withdraw",
				"Light-Screen",
				"Reflect",
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
				"Facade",
				"Nature-Power",
				"Superpower",
				"Secret-Power",
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
				"Round",
				"Grass-Pledge",
				"Work-Up",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}