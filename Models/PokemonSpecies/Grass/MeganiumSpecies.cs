using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Meganium Species to store common natural stats of all Meganiums
	#region MeganiumSpecies
	public class MeganiumSpecies : PokemonSpecies
	{
#nullable enable
		private static MeganiumSpecies? _instance = null;
#nullable restore
        public static MeganiumSpecies Instance => _instance ?? (_instance = new MeganiumSpecies());

		#region MeganiumSpecies Constructor
		public MeganiumSpecies() : base(
			154,
			"Meganium",
			Grass.Instance,
			1.8,
			100.5,
			new PokemonStats(
				80, // HPs
				82, 100, // Attack & Defense
				83, 100, // Spacial Attack & Defense
				80 // Speed
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
				"Hyper-Beam",
				"Counter",
				"Strength",
				"Razor-Leaf",
				"Solar-Beam",
				"Poison-Powder",
				"Petal-Dance",
				"Earthquake",
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
				"Outrage",
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
				"Frenzy-Plant",
				"Magical-Leaf",
				"Natural-Gift",
				"Worry-Seed",
				"Seed-Bomb",
				"Energy-Ball",
				"Giga-Impact",
				"Rock-Climb",
				"Captivate",
				"Grass-Knot",
				"Round",
				"Echoed-Voice",
				"Grass-Pledge",
				"Bulldoze",
				"Dragon-Tail",
				"Work-Up",
				"Petal-Blizzard",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}