using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Roselia Species to store common natural stats of all Roselias
	#region RoseliaSpecies
	public class RoseliaSpecies : PokemonSpecies
	{
#nullable enable
		private static RoseliaSpecies? _instance = null;
#nullable restore
        public static RoseliaSpecies Instance => _instance ?? (_instance = new RoseliaSpecies());

		#region RoseliaSpecies Constructor
		public RoseliaSpecies() : base(
			315,
			"Roselia",
			Grass.Instance, Poison.Instance,
			0.3,
			2.0,
			new PokemonStats(
				50, // HPs
				60, 45, // Attack & Defense
				100, 80, // Spacial Attack & Defense
				65 // Speed
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
				"Body-Slam",
				"Double-Edge",
				"Poison-Sting",
				"Pin-Missile",
				"Absorb",
				"Mega-Drain",
				"Leech-Seed",
				"Growth",
				"Razor-Leaf",
				"Solar-Beam",
				"Stun-Spore",
				"Sleep-Powder",
				"Petal-Dance",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Swift",
				"Flash",
				"Rest",
				"Substitute",
				"Mind-Reader",
				"Nightmare",
				"Snore",
				"Cotton-Spore",
				"Protect",
				"Sludge-Bomb",
				"Mud-Slap",
				"Spikes",
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
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Facade",
				"Nature-Power",
				"Ingrain",
				"Secret-Power",
				"Aromatherapy",
				"Grass-Whistle",
				"Bullet-Seed",
				"Covet",
				"Magical-Leaf",
				"Natural-Gift",
				"Worry-Seed",
				"Toxic-Spikes",
				"Poison-Jab",
				"Seed-Bomb",
				"Energy-Ball",
				"Leaf-Storm",
				"Power-Whip",
				"Captivate",
				"Grass-Knot",
				"Venoshock",
				"Round",
				"Petal-Blizzard",
				"Confide",
				"Dazzling-Gleam"
			};
		}
		#endregion
	}
	#endregion
}