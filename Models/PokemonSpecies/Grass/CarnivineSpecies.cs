using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Carnivine Species to store common natural stats of all Carnivines
	#region CarnivineSpecies
	public class CarnivineSpecies : PokemonSpecies
	{
#nullable enable
		private static CarnivineSpecies? _instance = null;
#nullable restore
        public static CarnivineSpecies Instance => _instance ?? (_instance = new CarnivineSpecies());

		#region CarnivineSpecies Constructor
		public CarnivineSpecies() : base(
			455,
			"Carnivine",
			Grass.Instance,
			1.4,
			27.0,
			new PokemonStats(
				74, // HPs
				100, 72, // Attack & Defense
				90, 72, // Spacial Attack & Defense
				46 // Speed
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
				"Bind",
				"Slam",
				"Vine-Whip",
				"Bite",
				"Hyper-Beam",
				"Leech-Seed",
				"Growth",
				"Razor-Leaf",
				"Solar-Beam",
				"Stun-Spore",
				"Sleep-Powder",
				"Toxic",
				"Double-Team",
				"Flash",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Protect",
				"Feint-Attack",
				"Sludge-Bomb",
				"Mud-Slap",
				"Giga-Drain",
				"Endure",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Sweet-Scent",
				"Synthesis",
				"Hidden-Power",
				"Sunny-Day",
				"Crunch",
				"Stockpile",
				"Spit-Up",
				"Swallow",
				"Facade",
				"Nature-Power",
				"Ingrain",
				"Knock-Off",
				"Secret-Power",
				"Grass-Whistle",
				"Bullet-Seed",
				"Magical-Leaf",
				"Natural-Gift",
				"Payback",
				"Fling",
				"Wring-Out",
				"Gastro-Acid",
				"Worry-Seed",
				"Seed-Bomb",
				"Energy-Ball",
				"Giga-Impact",
				"Power-Whip",
				"Captivate",
				"Grass-Knot",
				"Bug-Bite",
				"Rage-Powder",
				"Acid-Spray",
				"Round",
				"Leaf-Tornado",
				"Confide",
				"Infestation"
			};
		}
		#endregion
	}
	#endregion
}