using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Swablu Species to store common natural stats of all Swablus
	#region SwabluSpecies
	public class SwabluSpecies : PokemonSpecies
	{
#nullable enable
		private static SwabluSpecies? _instance = null;
#nullable restore
        public static SwabluSpecies Instance => _instance ?? (_instance = new SwabluSpecies());

		#region SwabluSpecies Constructor
		public SwabluSpecies() : base(
			333,
			"Swablu",
			Normal.Instance, Flying.Instance,
			0.4,
			1.2,
			new PokemonStats(
				45, // HPs
				40, 60, // Attack & Defense
				40, 75, // Spacial Attack & Defense
				50 // Speed
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
				"Fury-Attack",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Growl",
				"Sing",
				"Mist",
				"Ice-Beam",
				"Peck",
				"Solar-Beam",
				"Toxic",
				"Agility",
				"Rage",
				"Mimic",
				"Double-Team",
				"Haze",
				"Mirror-Move",
				"Swift",
				"Dream-Eater",
				"Sky-Attack",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Protect",
				"Mud-Slap",
				"Perish-Song",
				"Outrage",
				"Endure",
				"Swagger",
				"Steel-Wing",
				"Attract",
				"Sleep-Talk",
				"Heal-Bell",
				"Return",
				"Frustration",
				"Safeguard",
				"Pursuit",
				"Hidden-Power",
				"Twister",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Uproar",
				"Heat-Wave",
				"Facade",
				"Refresh",
				"Secret-Power",
				"Feather-Dance",
				"Hyper-Voice",
				"Astonish",
				"Air-Cutter",
				"Aerial-Ace",
				"Roost",
				"Natural-Gift",
				"Pluck",
				"Tailwind",
				"Power-Swap",
				"Dragon-Pulse",
				"Dragon-Rush",
				"Captivate",
				"Ominous-Wind",
				"Round",
				"Echoed-Voice",
				"Cotton-Guard",
				"Disarming-Voice",
				"Play-Rough",
				"Moonblast",
				"Confide",
				"Dazzling-Gleam"
			};
		}
		#endregion
	}
	#endregion
}