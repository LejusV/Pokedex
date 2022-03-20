using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Swellow Species to store common natural stats of all Swellows
	#region SwellowSpecies
	public class SwellowSpecies : PokemonSpecies
	{
#nullable enable
		private static SwellowSpecies? _instance = null;
#nullable restore
        public static SwellowSpecies Instance => _instance ?? (_instance = new SwellowSpecies());

		#region SwellowSpecies Constructor
		public SwellowSpecies() : base(
			277,
			"Swellow",
			Normal.Instance, Flying.Instance,
			0.7,
			19.8,
			new PokemonStats(
				60, // HPs
				85, 60, // Attack & Defense
				75, 50, // Spacial Attack & Defense
				125 // Speed
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
				"Double-Edge",
				"Growl",
				"Hyper-Beam",
				"Peck",
				"Counter",
				"Toxic",
				"Agility",
				"Quick-Attack",
				"Mimic",
				"Double-Team",
				"Focus-Energy",
				"Swift",
				"Sky-Attack",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Reversal",
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
				"Air-Slash",
				"Brave-Bird",
				"Giga-Impact",
				"Defog",
				"Captivate",
				"Ominous-Wind",
				"Round",
				"Echoed-Voice",
				"Quick-Guard",
				"Work-Up",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}