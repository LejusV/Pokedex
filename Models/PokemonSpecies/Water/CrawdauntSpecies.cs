using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Crawdaunt Species to store common natural stats of all Crawdaunts
	#region CrawdauntSpecies
	public class CrawdauntSpecies : PokemonSpecies
	{
#nullable enable
		private static CrawdauntSpecies? _instance = null;
#nullable restore
        public static CrawdauntSpecies Instance => _instance ?? (_instance = new CrawdauntSpecies());

		#region CrawdauntSpecies Constructor
		public CrawdauntSpecies() : base(
			342,
			"Crawdaunt",
			Water.Instance, Dark.Instance,
			1.1,
			32.8,
			new PokemonStats(
				63, // HPs
				120, 85, // Attack & Defense
				90, 55, // Spacial Attack & Defense
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
				"Vice-Grip",
				"Guillotine",
				"Swords-Dance",
				"Cut",
				"Body-Slam",
				"Double-Edge",
				"Leer",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Bubble-Beam",
				"Hyper-Beam",
				"Counter",
				"Strength",
				"Dig",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Harden",
				"Waterfall",
				"Swift",
				"Bubble",
				"Crabhammer",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Spite",
				"Protect",
				"Sludge-Bomb",
				"Mud-Slap",
				"Icy-Wind",
				"Endure",
				"False-Swipe",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Rain-Dance",
				"Crunch",
				"Ancient-Power",
				"Rock-Smash",
				"Whirlpool",
				"Hail",
				"Facade",
				"Nature-Power",
				"Taunt",
				"Superpower",
				"Brick-Break",
				"Knock-Off",
				"Endeavor",
				"Secret-Power",
				"Dive",
				"Rock-Tomb",
				"Aerial-Ace",
				"Iron-Defense",
				"Water-Pulse",
				"Natural-Gift",
				"Payback",
				"Fling",
				"Dark-Pulse",
				"Night-Slash",
				"X-Scissor",
				"Giga-Impact",
				"Avalanche",
				"Captivate",
				"Double-Hit",
				"Hone-Claws",
				"Sludge-Wave",
				"Round",
				"Scald",
				"Retaliate",
				"Razor-Shell",
				"Snarl",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}