using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Tranquill Species to store common natural stats of all Tranquills
	#region TranquillSpecies
	public class TranquillSpecies : PokemonSpecies
	{
#nullable enable
		private static TranquillSpecies? _instance = null;
#nullable restore
        public static TranquillSpecies Instance => _instance ?? (_instance = new TranquillSpecies());

		#region TranquillSpecies Constructor
		public TranquillSpecies() : base(
			520,
			"Tranquill",
			Normal.Instance, Flying.Instance,
			0.6,
			15.0,
			new PokemonStats(
				62, // HPs
				77, 62, // Attack & Defense
				50, 42, // Spacial Attack & Defense
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
				"Razor-Wind",
				"Gust",
				"Fly",
				"Leer",
				"Growl",
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