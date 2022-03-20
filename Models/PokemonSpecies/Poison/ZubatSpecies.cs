using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Zubat Species to store common natural stats of all Zubats
	#region ZubatSpecies
	public class ZubatSpecies : PokemonSpecies
	{
#nullable enable
		private static ZubatSpecies? _instance = null;
#nullable restore
        public static ZubatSpecies Instance => _instance ?? (_instance = new ZubatSpecies());

		#region ZubatSpecies Constructor
		public ZubatSpecies() : base(
			41,
			"Zubat",
			Poison.Instance, Flying.Instance,
			0.8,
			7.5,
			new PokemonStats(
				40, // HPs
				45, 35, // Attack & Defense
				30, 40, // Spacial Attack & Defense
				55 // Speed
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
				"Take-Down",
				"Double-Edge",
				"Bite",
				"Supersonic",
				"Absorb",
				"Mega-Drain",
				"Toxic",
				"Hypnosis",
				"Quick-Attack",
				"Rage",
				"Mimic",
				"Double-Team",
				"Confuse-Ray",
				"Haze",
				"Bide",
				"Swift",
				"Leech-Life",
				"Rest",
				"Super-Fang",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Protect",
				"Feint-Attack",
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
				"Pursuit",
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
				"Air-Slash",
				"Brave-Bird",
				"Nasty-Plot",
				"Zen-Headbutt",
				"Defog",
				"Captivate",
				"Ominous-Wind",
				"Venoshock",
				"Round",
				"Quick-Guard",
				"Acrobatics",
				"Confide",
				"Venom-Drench"
			};
		}
		#endregion
	}
	#endregion
}