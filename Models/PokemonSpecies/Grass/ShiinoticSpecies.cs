using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Shiinotic Species to store common natural stats of all Shiinotics
	#region ShiinoticSpecies
	public class ShiinoticSpecies : PokemonSpecies
	{
#nullable enable
		private static ShiinoticSpecies? _instance = null;
#nullable restore
        public static ShiinoticSpecies Instance => _instance ?? (_instance = new ShiinoticSpecies());

		#region ShiinoticSpecies Constructor
		public ShiinoticSpecies() : base(
			756,
			"Shiinotic",
			Grass.Instance, Fairy.Instance,
			1.0,
			11.5,
			new PokemonStats(
				60, // HPs
				45, 80, // Attack & Defense
				90, 100, // Spacial Attack & Defense
				30 // Speed
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
				"Absorb",
				"Mega-Drain",
				"Solar-Beam",
				"Sleep-Powder",
				"Thunder-Wave",
				"Toxic",
				"Double-Team",
				"Confuse-Ray",
				"Light-Screen",
				"Dream-Eater",
				"Spore",
				"Flash",
				"Rest",
				"Substitute",
				"Protect",
				"Sludge-Bomb",
				"Giga-Drain",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Moonlight",
				"Hidden-Power",
				"Sunny-Day",
				"Nature-Power",
				"Ingrain",
				"Astonish",
				"Energy-Ball",
				"Giga-Impact",
				"Grass-Knot",
				"Charge-Beam",
				"Round",
				"Moonblast",
				"Confide",
				"Dazzling-Gleam",
				"Strength-Sap",
				"Spotlight"
			};
		}
		#endregion
	}
	#endregion
}