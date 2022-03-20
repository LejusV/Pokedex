using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Pidgey Species to store common natural stats of all Pidgeys
	#region PidgeySpecies
	public class PidgeySpecies : PokemonSpecies
	{
#nullable enable
		private static PidgeySpecies? _instance = null;
#nullable restore
        public static PidgeySpecies Instance => _instance ?? (_instance = new PidgeySpecies());

		#region PidgeySpecies Constructor
		public PidgeySpecies() : base(
			16,
			"Pidgey",
			Normal.Instance, Flying.Instance,
			0.3,
			1.8,
			new PokemonStats(
				40, // HPs
				45, 40, // Attack & Defense
				35, 35, // Spacial Attack & Defense
				56 // Speed
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
				"Wing-Attack",
				"Whirlwind",
				"Fly",
				"Sand-Attack",
				"Tackle",
				"Take-Down",
				"Double-Edge",
				"Toxic",
				"Agility",
				"Quick-Attack",
				"Rage",
				"Mimic",
				"Double-Team",
				"Reflect",
				"Bide",
				"Mirror-Move",
				"Swift",
				"Sky-Attack",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Protect",
				"Feint-Attack",
				"Mud-Slap",
				"Foresight",
				"Detect",
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
				"Uproar",
				"Heat-Wave",
				"Facade",
				"Secret-Power",
				"Feather-Dance",
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
				"Work-Up",
				"Hurricane",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}