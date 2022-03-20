using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Crobat Species to store common natural stats of all Crobats
	#region CrobatSpecies
	public class CrobatSpecies : PokemonSpecies
	{
#nullable enable
		private static CrobatSpecies? _instance = null;
#nullable restore
        public static CrobatSpecies Instance => _instance ?? (_instance = new CrobatSpecies());

		#region CrobatSpecies Constructor
		public CrobatSpecies() : base(
			169,
			"Crobat",
			Poison.Instance, Flying.Instance,
			1.8,
			75.0,
			new PokemonStats(
				85, // HPs
				90, 80, // Attack & Defense
				70, 80, // Spacial Attack & Defense
				130 // Speed
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
				"Bite",
				"Supersonic",
				"Hyper-Beam",
				"Absorb",
				"Toxic",
				"Mimic",
				"Screech",
				"Double-Team",
				"Confuse-Ray",
				"Haze",
				"Swift",
				"Leech-Life",
				"Sky-Attack",
				"Rest",
				"Super-Fang",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Protect",
				"Sludge-Bomb",
				"Detect",
				"Giga-Drain",
				"Endure",
				"Swagger",
				"Steel-Wing",
				"Mean-Look",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Twister",
				"Rain-Dance",
				"Sunny-Day",
				"Shadow-Ball",
				"Uproar",
				"Heat-Wave",
				"Torment",
				"Facade",
				"Taunt",
				"Snatch",
				"Secret-Power",
				"Poison-Fang",
				"Astonish",
				"Air-Cutter",
				"Aerial-Ace",
				"Roost",
				"Natural-Gift",
				"Pluck",
				"Tailwind",
				"U-Turn",
				"Payback",
				"Dark-Pulse",
				"Air-Slash",
				"X-Scissor",
				"Giga-Impact",
				"Zen-Headbutt",
				"Defog",
				"Cross-Poison",
				"Captivate",
				"Ominous-Wind",
				"Venoshock",
				"Round",
				"Quick-Guard",
				"Acrobatics",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}