using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Staraptor Species to store common natural stats of all Staraptors
	#region StaraptorSpecies
	public class StaraptorSpecies : PokemonSpecies
	{
#nullable enable
		private static StaraptorSpecies? _instance = null;
#nullable restore
        public static StaraptorSpecies Instance => _instance ?? (_instance = new StaraptorSpecies());

		#region StaraptorSpecies Constructor
		public StaraptorSpecies() : base(
			398,
			"Staraptor",
			Normal.Instance, Flying.Instance,
			1.2,
			24.9,
			new PokemonStats(
				85, // HPs
				120, 70, // Attack & Defense
				50, 60, // Spacial Attack & Defense
				100 // Speed
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
				"Hyper-Beam",
				"Toxic",
				"Agility",
				"Quick-Attack",
				"Double-Team",
				"Swift",
				"Sky-Attack",
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
				"Close-Combat",
				"Brave-Bird",
				"Giga-Impact",
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