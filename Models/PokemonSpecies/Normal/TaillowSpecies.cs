using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Taillow Species to store common natural stats of all Taillows
	#region TaillowSpecies
	public class TaillowSpecies : PokemonSpecies
	{
#nullable enable
		private static TaillowSpecies? _instance = null;
#nullable restore
        public static TaillowSpecies Instance => _instance ?? (_instance = new TaillowSpecies());

		#region TaillowSpecies Constructor
		public TaillowSpecies() : base(
			276,
			"Taillow",
			Normal.Instance, Flying.Instance,
			0.3,
			2.3,
			new PokemonStats(
				40, // HPs
				55, 30, // Attack & Defense
				30, 30, // Spacial Attack & Defense
				85 // Speed
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
				"Double-Edge",
				"Growl",
				"Supersonic",
				"Peck",
				"Counter",
				"Toxic",
				"Agility",
				"Quick-Attack",
				"Rage",
				"Mimic",
				"Double-Team",
				"Focus-Energy",
				"Mirror-Move",
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
				"Pursuit",
				"Hidden-Power",
				"Twister",
				"Rain-Dance",
				"Sunny-Day",
				"Heat-Wave",
				"Facade",
				"Endeavor",
				"Refresh",
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
				"Defog",
				"Captivate",
				"Ominous-Wind",
				"Round",
				"Echoed-Voice",
				"Quick-Guard",
				"Work-Up",
				"Hurricane",
				"Boomburst",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}