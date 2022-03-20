using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Kingler Species to store common natural stats of all Kinglers
	#region KinglerSpecies
	public class KinglerSpecies : PokemonSpecies
	{
#nullable enable
		private static KinglerSpecies? _instance = null;
#nullable restore
        public static KinglerSpecies Instance => _instance ?? (_instance = new KinglerSpecies());

		#region KinglerSpecies Constructor
		public KinglerSpecies() : base(
			99,
			"Kingler",
			Water.Instance,
			1.3,
			60.0,
			new PokemonStats(
				55, // HPs
				130, 115, // Attack & Defense
				50, 50, // Spacial Attack & Defense
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
				"Vice-Grip",
				"Guillotine",
				"Swords-Dance",
				"Cut",
				"Slam",
				"Stomp",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Leer",
				"Water-Gun",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Bubble-Beam",
				"Hyper-Beam",
				"Strength",
				"Dig",
				"Toxic",
				"Rage",
				"Mimic",
				"Double-Team",
				"Harden",
				"Bide",
				"Bubble",
				"Crabhammer",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Flail",
				"Protect",
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
				"Ancient-Power",
				"Rock-Smash",
				"Whirlpool",
				"Hail",
				"Facade",
				"Superpower",
				"Brick-Break",
				"Knock-Off",
				"Secret-Power",
				"Dive",
				"Mud-Sport",
				"Rock-Tomb",
				"Iron-Defense",
				"Mud-Shot",
				"Water-Pulse",
				"Brine",
				"Natural-Gift",
				"Fling",
				"X-Scissor",
				"Giga-Impact",
				"Captivate",
				"Hone-Claws",
				"Wide-Guard",
				"Round",
				"Scald",
				"Quash",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}