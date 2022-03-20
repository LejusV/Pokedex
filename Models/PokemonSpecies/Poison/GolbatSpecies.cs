using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Golbat Species to store common natural stats of all Golbats
	#region GolbatSpecies
	public class GolbatSpecies : PokemonSpecies
	{
#nullable enable
		private static GolbatSpecies? _instance = null;
#nullable restore
        public static GolbatSpecies Instance => _instance ?? (_instance = new GolbatSpecies());

		#region GolbatSpecies Constructor
		public GolbatSpecies() : base(
			42,
			"Golbat",
			Poison.Instance, Flying.Instance,
			1.6,
			55.0,
			new PokemonStats(
				75, // HPs
				80, 70, // Attack & Defense
				65, 75, // Spacial Attack & Defense
				90 // Speed
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
				"Wing-Attack",
				"Whirlwind",
				"Fly",
				"Take-Down",
				"Double-Edge",
				"Bite",
				"Supersonic",
				"Hyper-Beam",
				"Absorb",
				"Mega-Drain",
				"Toxic",
				"Rage",
				"Mimic",
				"Screech",
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
				"Air-Slash",
				"Giga-Impact",
				"Zen-Headbutt",
				"Defog",
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