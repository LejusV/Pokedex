using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Anorith Species to store common natural stats of all Anoriths
	#region AnorithSpecies
	public class AnorithSpecies : PokemonSpecies
	{
#nullable enable
		private static AnorithSpecies? _instance = null;
#nullable restore
        public static AnorithSpecies Instance => _instance ?? (_instance = new AnorithSpecies());

		#region AnorithSpecies Constructor
		public AnorithSpecies() : base(
			347,
			"Anorith",
			Rock.Instance, Bug.Instance,
			0.7,
			12.5,
			new PokemonStats(
				45, // HPs
				95, 50, // Attack & Defense
				40, 50, // Spacial Attack & Defense
				75 // Speed
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
				"Scratch",
				"Swords-Dance",
				"Cut",
				"Sand-Attack",
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Water-Gun",
				"String-Shot",
				"Dig",
				"Toxic",
				"Mimic",
				"Screech",
				"Double-Team",
				"Harden",
				"Rest",
				"Rock-Slide",
				"Slash",
				"Substitute",
				"Snore",
				"Curse",
				"Protect",
				"Mud-Slap",
				"Sandstorm",
				"Endure",
				"False-Swipe",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Rapid-Spin",
				"Metal-Claw",
				"Hidden-Power",
				"Sunny-Day",
				"Ancient-Power",
				"Rock-Smash",
				"Facade",
				"Brick-Break",
				"Knock-Off",
				"Secret-Power",
				"Mud-Sport",
				"Crush-Claw",
				"Rock-Tomb",
				"Aerial-Ace",
				"Iron-Defense",
				"Rock-Blast",
				"Water-Pulse",
				"Brine",
				"Natural-Gift",
				"Rock-Polish",
				"X-Scissor",
				"Earth-Power",
				"Cross-Poison",
				"Captivate",
				"Stealth-Rock",
				"Bug-Bite",
				"Aqua-Jet",
				"Hone-Claws",
				"Smack-Down",
				"Round",
				"Struggle-Bug",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}