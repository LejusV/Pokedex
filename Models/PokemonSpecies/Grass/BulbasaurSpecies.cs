using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Bulbasaur Species to store common natural stats of all Bulbasaurs
	#region BulbasaurSpecies
	public class BulbasaurSpecies : PokemonSpecies
	{
#nullable enable
		private static BulbasaurSpecies? _instance = null;
#nullable restore
        public static BulbasaurSpecies Instance => _instance ?? (_instance = new BulbasaurSpecies());

		#region BulbasaurSpecies Constructor
		public BulbasaurSpecies() : base(
			1,
			"Bulbasaur",
			Grass.Instance, Poison.Instance,
			0.7,
			6.9,
			new PokemonStats(
				45, // HPs
				49, 49, // Attack & Defense
				65, 65, // Spacial Attack & Defense
				45 // Speed
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
				"Cut",
				"Bind",
				"Vine-Whip",
				"Headbutt",
				"Tackle",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Growl",
				"Strength",
				"Mega-Drain",
				"Leech-Seed",
				"Growth",
				"Razor-Leaf",
				"Solar-Beam",
				"Poison-Powder",
				"Sleep-Powder",
				"Petal-Dance",
				"String-Shot",
				"Toxic",
				"Rage",
				"Mimic",
				"Double-Team",
				"Defense-Curl",
				"Light-Screen",
				"Reflect",
				"Bide",
				"Sludge",
				"Skull-Bash",
				"Amnesia",
				"Flash",
				"Rest",
				"Substitute",
				"Snore",
				"Curse",
				"Protect",
				"Sludge-Bomb",
				"Mud-Slap",
				"Giga-Drain",
				"Endure",
				"Charm",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Sweet-Scent",
				"Synthesis",
				"Hidden-Power",
				"Sunny-Day",
				"Rock-Smash",
				"Facade",
				"Nature-Power",
				"Ingrain",
				"Knock-Off",
				"Secret-Power",
				"Grass-Whistle",
				"Bullet-Seed",
				"Magical-Leaf",
				"Natural-Gift",
				"Worry-Seed",
				"Seed-Bomb",
				"Energy-Ball",
				"Leaf-Storm",
				"Power-Whip",
				"Captivate",
				"Grass-Knot",
				"Venoshock",
				"Round",
				"Echoed-Voice",
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