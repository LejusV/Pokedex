using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Tapu-Koko Species to store common natural stats of all Tapu-Kokos
	#region Tapu-KokoSpecies
	public class TapuKokoSpecies : PokemonSpecies
	{
#nullable enable
		private static TapuKokoSpecies? _instance = null;
#nullable restore
        public static TapuKokoSpecies Instance => _instance ?? (_instance = new TapuKokoSpecies());

		#region Tapu-KokoSpecies Constructor
		public TapuKokoSpecies() : base(
			785,
			"Tapu-Koko",
			Electric.Instance, Fairy.Instance,
			1.8,
			20.5,
			new PokemonStats(
				70, // HPs
				115, 85, // Attack & Defense
				95, 75, // Spacial Attack & Defense
				130 // Speed
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
				"Fly",
				"Roar",
				"Hyper-Beam",
				"Thunder-Shock",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Toxic",
				"Agility",
				"Quick-Attack",
				"Screech",
				"Double-Team",
				"Withdraw",
				"Light-Screen",
				"Reflect",
				"Mirror-Move",
				"Substitute",
				"Thief",
				"Protect",
				"False-Swipe",
				"Swagger",
				"Spark",
				"Steel-Wing",
				"Mean-Look",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Hidden-Power",
				"Rain-Dance",
				"Psych-Up",
				"Torment",
				"Facade",
				"Nature-Power",
				"Charge",
				"Taunt",
				"Aerial-Ace",
				"Calm-Mind",
				"Shock-Wave",
				"Roost",
				"U-Turn",
				"Power-Swap",
				"Brave-Bird",
				"Giga-Impact",
				"Discharge",
				"Grass-Knot",
				"Electro-Ball",
				"Round",
				"Echoed-Voice",
				"Sky-Drop",
				"Acrobatics",
				"Volt-Switch",
				"Work-Up",
				"Wild-Charge",
				"Confide",
				"Electric-Terrain",
				"Dazzling-Gleam",
				"Natures-Madness"
			};
		}
		#endregion
	}
	#endregion
}