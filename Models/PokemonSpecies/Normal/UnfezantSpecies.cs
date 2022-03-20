using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Unfezant Species to store common natural stats of all Unfezants
	#region UnfezantSpecies
	public class UnfezantSpecies : PokemonSpecies
	{
#nullable enable
		private static UnfezantSpecies? _instance = null;
#nullable restore
        public static UnfezantSpecies Instance => _instance ?? (_instance = new UnfezantSpecies());

		#region UnfezantSpecies Constructor
		public UnfezantSpecies() : base(
			521,
			"Unfezant",
			Normal.Instance, Flying.Instance,
			1.2,
			29.0,
			new PokemonStats(
				80, // HPs
				115, 80, // Attack & Defense
				65, 55, // Spacial Attack & Defense
				93 // Speed
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
				"Razor-Wind",
				"Gust",
				"Fly",
				"Leer",
				"Growl",
				"Hyper-Beam",
				"Toxic",
				"Quick-Attack",
				"Double-Team",
				"Sky-Attack",
				"Rest",
				"Substitute",
				"Snore",
				"Protect",
				"Detect",
				"Swagger",
				"Steel-Wing",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Uproar",
				"Heat-Wave",
				"Facade",
				"Taunt",
				"Secret-Power",
				"Feather-Dance",
				"Air-Cutter",
				"Aerial-Ace",
				"Roost",
				"Pluck",
				"Tailwind",
				"U-Turn",
				"Air-Slash",
				"Giga-Impact",
				"Round",
				"Echoed-Voice",
				"Work-Up",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}