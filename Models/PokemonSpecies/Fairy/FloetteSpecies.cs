using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Floette Species to store common natural stats of all Floettes
	#region FloetteSpecies
	public class FloetteSpecies : PokemonSpecies
	{
#nullable enable
		private static FloetteSpecies? _instance = null;
#nullable restore
        public static FloetteSpecies Instance => _instance ?? (_instance = new FloetteSpecies());

		#region FloetteSpecies Constructor
		public FloetteSpecies() : base(
			670,
			"Floette",
			Fairy.Instance,
			0.2,
			0.9,
			new PokemonStats(
				54, // HPs
				45, 47, // Attack & Defense
				75, 98, // Spacial Attack & Defense
				52 // Speed
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
				"Vine-Whip",
				"Tackle",
				"Razor-Leaf",
				"Solar-Beam",
				"Petal-Dance",
				"Toxic",
				"Psychic",
				"Double-Team",
				"Flash",
				"Rest",
				"Substitute",
				"Snore",
				"Protect",
				"Giga-Drain",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Heal-Bell",
				"Return",
				"Frustration",
				"Safeguard",
				"Synthesis",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Facade",
				"Nature-Power",
				"Helping-Hand",
				"Wish",
				"Magic-Coat",
				"Endeavor",
				"Secret-Power",
				"Aromatherapy",
				"Covet",
				"Magical-Leaf",
				"Calm-Mind",
				"Lucky-Chant",
				"Worry-Seed",
				"Seed-Bomb",
				"Energy-Ball",
				"Grass-Knot",
				"After-You",
				"Round",
				"Echoed-Voice",
				"Petal-Blizzard",
				"Grassy-Terrain",
				"Misty-Terrain",
				"Fairy-Wind",
				"Moonblast",
				"Confide",
				"Dazzling-Gleam"
			};
		}
		#endregion
	}
	#endregion
}