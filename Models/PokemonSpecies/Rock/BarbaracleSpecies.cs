using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Barbaracle Species to store common natural stats of all Barbaracles
	#region BarbaracleSpecies
	public class BarbaracleSpecies : PokemonSpecies
	{
#nullable enable
		private static BarbaracleSpecies? _instance = null;
#nullable restore
        public static BarbaracleSpecies Instance => _instance ?? (_instance = new BarbaracleSpecies());

		#region BarbaracleSpecies Constructor
		public BarbaracleSpecies() : base(
			689,
			"Barbaracle",
			Rock.Instance, Water.Instance,
			1.3,
			96.0,
			new PokemonStats(
				72, // HPs
				105, 115, // Attack & Defense
				54, 86, // Spacial Attack & Defense
				68 // Speed
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
				"Hyper-Beam",
				"Low-Kick",
				"Strength",
				"Earthquake",
				"Dig",
				"Toxic",
				"Double-Team",
				"Withdraw",
				"Clamp",
				"Skull-Bash",
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
				"Superpower",
				"Brick-Break",
				"Endeavor",
				"Secret-Power",
				"Rock-Tomb",
				"Aerial-Ace",
				"Iron-Defense",
				"Dragon-Claw",
				"Bulk-Up",
				"Water-Pulse",
				"Payback",
				"Embargo",
				"Fling",
				"Rock-Polish",
				"Poison-Jab",
				"Night-Slash",
				"X-Scissor",
				"Focus-Blast",
				"Earth-Power",
				"Giga-Impact",
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
				"Power-Up-Punch",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion
}