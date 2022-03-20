using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Sneasel Species to store common natural stats of all Sneasels
	#region SneaselSpecies
	public class SneaselSpecies : PokemonSpecies
	{
#nullable enable
		private static SneaselSpecies? _instance = null;
#nullable restore
        public static SneaselSpecies Instance => _instance ?? (_instance = new SneaselSpecies());

		#region SneaselSpecies Constructor
		public SneaselSpecies() : base(
			215,
			"Sneasel",
			Dark.Instance, Ice.Instance,
			0.9,
			28.0,
			new PokemonStats(
				55, // HPs
				95, 55, // Attack & Defense
				35, 75, // Spacial Attack & Defense
				115 // Speed
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
				"Ice-Punch",
				"Scratch",
				"Swords-Dance",
				"Cut",
				"Headbutt",
				"Double-Edge",
				"Leer",
				"Bite",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Low-Kick",
				"Counter",
				"Strength",
				"Dig",
				"Toxic",
				"Agility",
				"Quick-Attack",
				"Mimic",
				"Screech",
				"Double-Team",
				"Defense-Curl",
				"Reflect",
				"Swift",
				"Dream-Eater",
				"Fury-Swipes",
				"Rest",
				"Slash",
				"Substitute",
				"Thief",
				"Nightmare",
				"Snore",
				"Curse",
				"Spite",
				"Protect",
				"Feint-Attack",
				"Mud-Slap",
				"Foresight",
				"Icy-Wind",
				"Detect",
				"Endure",
				"False-Swipe",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Dynamic-Punch",
				"Pursuit",
				"Iron-Tail",
				"Metal-Claw",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Rock-Smash",
				"Whirlpool",
				"Beat-Up",
				"Fake-Out",
				"Hail",
				"Torment",
				"Facade",
				"Focus-Punch",
				"Taunt",
				"Assist",
				"Brick-Break",
				"Knock-Off",
				"Snatch",
				"Secret-Power",
				"Crush-Claw",
				"Aerial-Ace",
				"Calm-Mind",
				"Natural-Gift",
				"Feint",
				"Payback",
				"Embargo",
				"Fling",
				"Punishment",
				"Poison-Jab",
				"Dark-Pulse",
				"X-Scissor",
				"Avalanche",
				"Ice-Shard",
				"Shadow-Claw",
				"Captivate",
				"Double-Hit",
				"Hone-Claws",
				"Low-Sweep",
				"Foul-Play",
				"Round",
				"Retaliate",
				"Snarl",
				"Icicle-Crash",
				"Confide",
				"Power-Up-Punch",
				"Throat-Chop"
			};
		}
		#endregion
	}
	#endregion
}