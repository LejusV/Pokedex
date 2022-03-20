using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Sandshrew Species to store common natural stats of all Sandshrews
	#region SandshrewSpecies
	public class SandshrewSpecies : PokemonSpecies
	{
#nullable enable
		private static SandshrewSpecies? _instance = null;
#nullable restore
        public static SandshrewSpecies Instance => _instance ?? (_instance = new SandshrewSpecies());

		#region SandshrewSpecies Constructor
		public SandshrewSpecies() : base(
			27,
			"Sandshrew",
			Ground.Instance,
			0.6,
			12.0,
			new PokemonStats(
				50, // HPs
				75, 85, // Attack & Defense
				20, 30, // Spacial Attack & Defense
				40 // Speed
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
				"Flail",
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
				"Metal-Claw",
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
				"Mud-Shot",
				"Covet",
				"Gyro-Ball",
				"Natural-Gift",
				"Fling",
				"Poison-Jab",
				"Night-Slash",
				"X-Scissor",
				"Earth-Power",
				"Shadow-Claw",
				"Rock-Climb",
				"Captivate",
				"Stealth-Rock",
				"Hone-Claws",
				"Round",
				"Chip-Away",
				"Bulldoze",
				"Rototiller",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}