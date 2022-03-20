using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Wingull Species to store common natural stats of all Wingulls
	#region WingullSpecies
	public class WingullSpecies : PokemonSpecies
	{
#nullable enable
		private static WingullSpecies? _instance = null;
#nullable restore
        public static WingullSpecies Instance => _instance ?? (_instance = new WingullSpecies());

		#region WingullSpecies Constructor
		public WingullSpecies() : base(
			278,
			"Wingull",
			Water.Instance, Flying.Instance,
			0.6,
			9.5,
			new PokemonStats(
				40, // HPs
				30, 30, // Attack & Defense
				55, 30, // Spacial Attack & Defense
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
				"Gust",
				"Wing-Attack",
				"Fly",
				"Double-Edge",
				"Growl",
				"Supersonic",
				"Mist",
				"Water-Gun",
				"Ice-Beam",
				"Blizzard",
				"Toxic",
				"Agility",
				"Quick-Attack",
				"Mimic",
				"Double-Team",
				"Swift",
				"Sky-Attack",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Protect",
				"Mud-Slap",
				"Icy-Wind",
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
				"Uproar",
				"Hail",
				"Facade",
				"Knock-Off",
				"Secret-Power",
				"Air-Cutter",
				"Aerial-Ace",
				"Water-Sport",
				"Shock-Wave",
				"Water-Pulse",
				"Roost",
				"Brine",
				"Natural-Gift",
				"Pluck",
				"Tailwind",
				"U-Turn",
				"Aqua-Ring",
				"Air-Slash",
				"Defog",
				"Captivate",
				"Ominous-Wind",
				"Wide-Guard",
				"Soak",
				"Round",
				"Echoed-Voice",
				"Scald",
				"Hurricane",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}