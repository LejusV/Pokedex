using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Swanna Species to store common natural stats of all Swannas
	#region SwannaSpecies
	public class SwannaSpecies : PokemonSpecies
	{
#nullable enable
		private static SwannaSpecies? _instance = null;
#nullable restore
        public static SwannaSpecies Instance => _instance ?? (_instance = new SwannaSpecies());

		#region SwannaSpecies Constructor
		public SwannaSpecies() : base(
			581,
			"Swanna",
			Water.Instance, Flying.Instance,
			1.3,
			24.2,
			new PokemonStats(
				75, // HPs
				87, 63, // Attack & Defense
				87, 63, // Spacial Attack & Defense
				98 // Speed
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
				"Wing-Attack",
				"Fly",
				"Water-Gun",
				"Surf",
				"Ice-Beam",
				"Bubble-Beam",
				"Hyper-Beam",
				"Toxic",
				"Double-Team",
				"Sky-Attack",
				"Rest",
				"Substitute",
				"Snore",
				"Protect",
				"Icy-Wind",
				"Swagger",
				"Steel-Wing",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Rain-Dance",
				"Uproar",
				"Hail",
				"Facade",
				"Endeavor",
				"Secret-Power",
				"Dive",
				"Feather-Dance",
				"Aerial-Ace",
				"Water-Sport",
				"Water-Pulse",
				"Roost",
				"Pluck",
				"Tailwind",
				"Aqua-Ring",
				"Air-Slash",
				"Brave-Bird",
				"Giga-Impact",
				"Defog",
				"Round",
				"Scald",
				"Hurricane",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}