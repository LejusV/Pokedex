using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Florges Species to store common natural stats of all Florgess
	#region FlorgesSpecies
	public class FlorgesSpecies : PokemonSpecies
	{
#nullable enable
		private static FlorgesSpecies? _instance = null;
#nullable restore
        public static FlorgesSpecies Instance => _instance ?? (_instance = new FlorgesSpecies());

		#region FlorgesSpecies Constructor
		public FlorgesSpecies() : base(
			671,
			"Florges",
			Fairy.Instance,
			1.1,
			10.0,
			new PokemonStats(
				78, // HPs
				65, 68, // Attack & Defense
				112, 154, // Spacial Attack & Defense
				75 // Speed
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
				"Hyper-Beam",
				"Solar-Beam",
				"Petal-Dance",
				"Toxic",
				"Psychic",
				"Double-Team",
				"Light-Screen",
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
				"Giga-Impact",
				"Grass-Knot",
				"After-You",
				"Round",
				"Echoed-Voice",
				"Petal-Blizzard",
				"Disarming-Voice",
				"Flower-Shield",
				"Grassy-Terrain",
				"Misty-Terrain",
				"Moonblast",
				"Confide",
				"Dazzling-Gleam"
			};
		}
		#endregion
	}
	#endregion
}