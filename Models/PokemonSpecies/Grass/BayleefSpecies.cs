using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Bayleef Species to store common natural stats of all Bayleefs
	#region BayleefSpecies
	public class BayleefSpecies : PokemonSpecies
	{
#nullable enable
		private static BayleefSpecies? _instance = null;
#nullable restore
        public static BayleefSpecies Instance => _instance ?? (_instance = new BayleefSpecies());

		#region BayleefSpecies Constructor
		public BayleefSpecies() : base(
			153,
			"Bayleef",
			Grass.Instance,
			1.2,
			15.8,
			new PokemonStats(
				60, // HPs
				62, 80, // Attack & Defense
				63, 80, // Spacial Attack & Defense
				60 // Speed
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
				"Double-Edge",
				"Growl",
				"Counter",
				"Strength",
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
				"Rock-Smash",
				"Facade",
				"Nature-Power",
				"Magic-Coat",
				"Secret-Power",
				"Aromatherapy",
				"Bullet-Seed",
				"Magical-Leaf",
				"Natural-Gift",
				"Worry-Seed",
				"Seed-Bomb",
				"Energy-Ball",
				"Captivate",
				"Grass-Knot",
				"Round",
				"Echoed-Voice",
				"Grass-Pledge",
				"Work-Up",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}