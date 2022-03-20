using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Sandslash Species to store common natural stats of all Sandslashs
	#region SandslashSpecies
	public class SandslashSpecies : PokemonSpecies
	{
#nullable enable
		private static SandslashSpecies? _instance = null;
#nullable restore
        public static SandslashSpecies Instance => _instance ?? (_instance = new SandslashSpecies());

		#region SandslashSpecies Constructor
		public SandslashSpecies() : base(
			28,
			"Sandslash",
			Ground.Instance,
			1.0,
			29.5,
			new PokemonStats(
				75, // HPs
				100, 110, // Attack & Defense
				45, 55, // Spacial Attack & Defense
				65 // Speed
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
				"Take-Down",
				"Double-Edge",
				"Poison-Sting",
				"Hyper-Beam",
				"Submission",
				"Counter",
				"Seismic-Toss",
				"Strength",
				"Earthquake",
				"Fissure",
				"Dig",
				"Toxic",
				"Rage",
				"Mimic",
				"Double-Team",
				"Defense-Curl",
				"Bide",
				"Swift",
				"Skull-Bash",
				"Fury-Swipes",
				"Rest",
				"Rock-Slide",
				"Super-Fang",
				"Slash",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Protect",
				"Mud-Slap",
				"Detect",
				"Sandstorm",
				"Endure",
				"Rollout",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Magnitude",
				"Dynamic-Punch",
				"Rapid-Spin",
				"Iron-Tail",
				"Hidden-Power",
				"Sunny-Day",
				"Rock-Smash",
				"Facade",
				"Focus-Punch",
				"Brick-Break",
				"Knock-Off",
				"Secret-Power",
				"Crush-Claw",
				"Rock-Tomb",
				"Sand-Tomb",
				"Aerial-Ace",
				"Covet",
				"Gyro-Ball",
				"Natural-Gift",
				"Fling",
				"Poison-Jab",
				"X-Scissor",
				"Focus-Blast",
				"Earth-Power",
				"Giga-Impact",
				"Shadow-Claw",
				"Rock-Climb",
				"Stone-Edge",
				"Captivate",
				"Stealth-Rock",
				"Hone-Claws",
				"Round",
				"Bulldoze",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}