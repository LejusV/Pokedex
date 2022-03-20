using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Roserade Species to store common natural stats of all Roserades
	#region RoseradeSpecies
	public class RoseradeSpecies : PokemonSpecies
	{
#nullable enable
		private static RoseradeSpecies? _instance = null;
#nullable restore
        public static RoseradeSpecies Instance => _instance ?? (_instance = new RoseradeSpecies());

		#region RoseradeSpecies Constructor
		public RoseradeSpecies() : base(
			407,
			"Roserade",
			Grass.Instance, Poison.Instance,
			0.9,
			14.5,
			new PokemonStats(
				60, // HPs
				70, 65, // Attack & Defense
				125, 105, // Spacial Attack & Defense
				90 // Speed
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
				"Poison-Sting",
				"Hyper-Beam",
				"Mega-Drain",
				"Solar-Beam",
				"Toxic",
				"Double-Team",
				"Swift",
				"Flash",
				"Rest",
				"Substitute",
				"Snore",
				"Protect",
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
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Facade",
				"Nature-Power",
				"Secret-Power",
				"Weather-Ball",
				"Bullet-Seed",
				"Covet",
				"Magical-Leaf",
				"Natural-Gift",
				"Worry-Seed",
				"Poison-Jab",
				"Seed-Bomb",
				"Energy-Ball",
				"Giga-Impact",
				"Captivate",
				"Grass-Knot",
				"Venoshock",
				"Round",
				"Grassy-Terrain",
				"Confide",
				"Venom-Drench",
				"Dazzling-Gleam"
			};
		}
		#endregion
	}
	#endregion
}