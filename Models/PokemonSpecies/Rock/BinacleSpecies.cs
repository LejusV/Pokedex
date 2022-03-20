using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Binacle Species to store common natural stats of all Binacles
	#region BinacleSpecies
	public class BinacleSpecies : PokemonSpecies
	{
#nullable enable
		private static BinacleSpecies? _instance = null;
#nullable restore
        public static BinacleSpecies Instance => _instance ?? (_instance = new BinacleSpecies());

		#region BinacleSpecies Constructor
		public BinacleSpecies() : base(
			688,
			"Binacle",
			Rock.Instance, Water.Instance,
			0.5,
			31.0,
			new PokemonStats(
				42, // HPs
				52, 67, // Attack & Defense
				39, 56, // Spacial Attack & Defense
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
				"Scratch",
				"Swords-Dance",
				"Cut",
				"Sand-Attack",
				"Water-Gun",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Strength",
				"Earthquake",
				"Dig",
				"Toxic",
				"Double-Team",
				"Withdraw",
				"Clamp",
				"Fury-Swipes",
				"Rest",
				"Rock-Slide",
				"Slash",
				"Substitute",
				"Thief",
				"Snore",
				"Protect",
				"Sludge-Bomb",
				"Mud-Slap",
				"Icy-Wind",
				"Sandstorm",
				"False-Swipe",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Hidden-Power",
				"Cross-Chop",
				"Rain-Dance",
				"Ancient-Power",
				"Rock-Smash",
				"Torment",
				"Facade",
				"Nature-Power",
				"Taunt",
				"Helping-Hand",
				"Brick-Break",
				"Endeavor",
				"Secret-Power",
				"Rock-Tomb",
				"Tickle",
				"Aerial-Ace",
				"Iron-Defense",
				"Water-Sport",
				"Water-Pulse",
				"Payback",
				"Embargo",
				"Fling",
				"Rock-Polish",
				"Poison-Jab",
				"Night-Slash",
				"X-Scissor",
				"Switcheroo",
				"Shadow-Claw",
				"Stone-Edge",
				"Stealth-Rock",
				"Grass-Knot",
				"Hone-Claws",
				"Smack-Down",
				"Sludge-Wave",
				"Round",
				"Scald",
				"Shell-Smash",
				"Bulldoze",
				"Dual-Chop",
				"Razor-Shell",
				"Confide",
				"Infestation",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion
}