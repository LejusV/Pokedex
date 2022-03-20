using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Chikorita Species to store common natural stats of all Chikoritas
	#region ChikoritaSpecies
	public class ChikoritaSpecies : PokemonSpecies
	{
#nullable enable
		private static ChikoritaSpecies? _instance = null;
#nullable restore
        public static ChikoritaSpecies Instance => _instance ?? (_instance = new ChikoritaSpecies());

		#region ChikoritaSpecies Constructor
		public ChikoritaSpecies() : base(
			152,
			"Chikorita",
			Grass.Instance,
			0.9,
			6.4,
			new PokemonStats(
				45, // HPs
				49, 65, // Attack & Defense
				49, 65, // Spacial Attack & Defense
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
				"Swords-Dance",
				"Cut",
				"Vine-Whip",
				"Headbutt",
				"Tackle",
				"Body-Slam",
				"Double-Edge",
				"Growl",
				"Counter",
				"Leech-Seed",
				"Razor-Leaf",
				"Solar-Beam",
				"Poison-Powder",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Light-Screen",
				"Reflect",
				"Flash",
				"Rest",
				"Substitute",
				"Snore",
				"Curse",
				"Flail",
				"Protect",
				"Mud-Slap",
				"Detect",
				"Giga-Drain",
				"Endure",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Sweet-Scent",
				"Iron-Tail",
				"Synthesis",
				"Hidden-Power",
				"Sunny-Day",
				"Ancient-Power",
				"Facade",
				"Nature-Power",
				"Ingrain",
				"Magic-Coat",
				"Refresh",
				"Secret-Power",
				"Aromatherapy",
				"Grass-Whistle",
				"Bullet-Seed",
				"Magical-Leaf",
				"Natural-Gift",
				"Wring-Out",
				"Worry-Seed",
				"Seed-Bomb",
				"Energy-Ball",
				"Leaf-Storm",
				"Captivate",
				"Grass-Knot",
				"Round",
				"Echoed-Voice",
				"Heal-Pulse",
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