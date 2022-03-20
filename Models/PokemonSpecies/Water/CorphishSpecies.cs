using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Corphish Species to store common natural stats of all Corphishs
	#region CorphishSpecies
	public class CorphishSpecies : PokemonSpecies
	{
#nullable enable
		private static CorphishSpecies? _instance = null;
#nullable restore
        public static CorphishSpecies Instance => _instance ?? (_instance = new CorphishSpecies());

		#region CorphishSpecies Constructor
		public CorphishSpecies() : base(
			341,
			"Corphish",
			Water.Instance,
			0.6,
			11.5,
			new PokemonStats(
				43, // HPs
				80, 65, // Attack & Defense
				50, 35, // Spacial Attack & Defense
				35 // Speed
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
				"Counter",
				"Strength",
				"Dig",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Harden",
				"Waterfall",
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
				"Metal-Claw",
				"Hidden-Power",
				"Rain-Dance",
				"Crunch",
				"Ancient-Power",
				"Rock-Smash",
				"Whirlpool",
				"Hail",
				"Facade",
				"Taunt",
				"Superpower",
				"Brick-Break",
				"Knock-Off",
				"Endeavor",
				"Secret-Power",
				"Mud-Sport",
				"Rock-Tomb",
				"Aerial-Ace",
				"Iron-Defense",
				"Dragon-Dance",
				"Water-Pulse",
				"Natural-Gift",
				"Payback",
				"Fling",
				"Trump-Card",
				"Night-Slash",
				"X-Scissor",
				"Switcheroo",
				"Captivate",
				"Aqua-Jet",
				"Double-Hit",
				"Hone-Claws",
				"Round",
				"Chip-Away",
				"Scald",
				"Razor-Shell",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}