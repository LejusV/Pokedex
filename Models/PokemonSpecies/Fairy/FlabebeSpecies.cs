using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Flabebe Species to store common natural stats of all Flabebes
	#region FlabebeSpecies
	public class FlabebeSpecies : PokemonSpecies
	{
#nullable enable
		private static FlabebeSpecies? _instance = null;
#nullable restore
        public static FlabebeSpecies Instance => _instance ?? (_instance = new FlabebeSpecies());

		#region FlabebeSpecies Constructor
		public FlabebeSpecies() : base(
			669,
			"Flabebe",
			Fairy.Instance,
			0.1,
			0.1,
			new PokemonStats(
				44, // HPs
				38, 39, // Attack & Defense
				61, 79, // Spacial Attack & Defense
				42 // Speed
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
				"Camouflage",
				"Aromatherapy",
				"Covet",
				"Magical-Leaf",
				"Calm-Mind",
				"Lucky-Chant",
				"Copycat",
				"Worry-Seed",
				"Seed-Bomb",
				"Energy-Ball",
				"Captivate",
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
				"Dazzling-Gleam",
				"Tearful-Look"
			};
		}
		#endregion
	}
	#endregion
}