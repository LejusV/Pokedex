using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Staravia Species to store common natural stats of all Staravias
	#region StaraviaSpecies
	public class StaraviaSpecies : PokemonSpecies
	{
#nullable enable
		private static StaraviaSpecies? _instance = null;
#nullable restore
        public static StaraviaSpecies Instance => _instance ?? (_instance = new StaraviaSpecies());

		#region StaraviaSpecies Constructor
		public StaraviaSpecies() : base(
			397,
			"Staravia",
			Normal.Instance, Flying.Instance,
			0.6,
			15.5,
			new PokemonStats(
				55, // HPs
				75, 50, // Attack & Defense
				40, 40, // Spacial Attack & Defense
				80 // Speed
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
				"Whirlwind",
				"Fly",
				"Tackle",
				"Take-Down",
				"Growl",
				"Toxic",
				"Agility",
				"Quick-Attack",
				"Double-Team",
				"Swift",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Protect",
				"Mud-Slap",
				"Endure",
				"Swagger",
				"Steel-Wing",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Twister",
				"Rain-Dance",
				"Sunny-Day",
				"Uproar",
				"Heat-Wave",
				"Facade",
				"Endeavor",
				"Secret-Power",
				"Air-Cutter",
				"Aerial-Ace",
				"Roost",
				"Natural-Gift",
				"Pluck",
				"Tailwind",
				"U-Turn",
				"Brave-Bird",
				"Defog",
				"Captivate",
				"Ominous-Wind",
				"Round",
				"Echoed-Voice",
				"Retaliate",
				"Final-Gambit",
				"Work-Up",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}