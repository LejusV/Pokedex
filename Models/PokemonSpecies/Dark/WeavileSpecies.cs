using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Weavile Species to store common natural stats of all Weaviles
	#region WeavileSpecies
	public class WeavileSpecies : PokemonSpecies
	{
#nullable enable
		private static WeavileSpecies? _instance = null;
#nullable restore
        public static WeavileSpecies Instance => _instance ?? (_instance = new WeavileSpecies());

		#region WeavileSpecies Constructor
		public WeavileSpecies() : base(
			461,
			"Weavile",
			Dark.Instance, Ice.Instance,
			1.1,
			34.0,
			new PokemonStats(
				70, // HPs
				120, 65, // Attack & Defense
				45, 85, // Spacial Attack & Defense
				125 // Speed
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
				"Leer",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Hyper-Beam",
				"Low-Kick",
				"Strength",
				"Dig",
				"Toxic",
				"Quick-Attack",
				"Screech",
				"Double-Team",
				"Reflect",
				"Swift",
				"Dream-Eater",
				"Fury-Swipes",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Spite",
				"Protect",
				"Feint-Attack",
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
				"Iron-Tail",
				"Metal-Claw",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Rock-Smash",
				"Whirlpool",
				"Hail",
				"Torment",
				"Facade",
				"Focus-Punch",
				"Taunt",
				"Revenge",
				"Brick-Break",
				"Knock-Off",
				"Snatch",
				"Secret-Power",
				"Aerial-Ace",
				"Calm-Mind",
				"Natural-Gift",
				"Payback",
				"Assurance",
				"Embargo",
				"Fling",
				"Punishment",
				"Poison-Jab",
				"Dark-Pulse",
				"Night-Slash",
				"X-Scissor",
				"Focus-Blast",
				"Giga-Impact",
				"Nasty-Plot",
				"Avalanche",
				"Shadow-Claw",
				"Captivate",
				"Hone-Claws",
				"Low-Sweep",
				"Foul-Play",
				"Round",
				"Retaliate",
				"Snarl",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion
}