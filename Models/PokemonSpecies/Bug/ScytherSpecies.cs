using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Scyther Species to store common natural stats of all Scythers
	#region ScytherSpecies
	public class ScytherSpecies : PokemonSpecies
	{
#nullable enable
		private static ScytherSpecies? _instance = null;
#nullable restore
        public static ScytherSpecies Instance => _instance ?? (_instance = new ScytherSpecies());

		#region ScytherSpecies Constructor
		public ScytherSpecies() : base(
			123,
			"Scyther",
			Bug.Instance, Flying.Instance,
			1.5,
			56.0,
			new PokemonStats(
				70, // HPs
				110, 80, // Attack & Defense
				55, 80, // Spacial Attack & Defense
				105 // Speed
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
				"Razor-Wind",
				"Swords-Dance",
				"Cut",
				"Wing-Attack",
				"Headbutt",
				"Take-Down",
				"Double-Edge",
				"Leer",
				"Hyper-Beam",
				"Counter",
				"Toxic",
				"Agility",
				"Quick-Attack",
				"Rage",
				"Mimic",
				"Double-Team",
				"Light-Screen",
				"Focus-Energy",
				"Bide",
				"Swift",
				"Skull-Bash",
				"Rest",
				"Slash",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Reversal",
				"Protect",
				"Detect",
				"Endure",
				"False-Swipe",
				"Swagger",
				"Fury-Cutter",
				"Steel-Wing",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Baton-Pass",
				"Pursuit",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Rock-Smash",
				"Facade",
				"Brick-Break",
				"Knock-Off",
				"Secret-Power",
				"Silver-Wind",
				"Aerial-Ace",
				"Roost",
				"Natural-Gift",
				"Feint",
				"Tailwind",
				"U-Turn",
				"Night-Slash",
				"Air-Slash",
				"X-Scissor",
				"Bug-Buzz",
				"Vacuum-Wave",
				"Giga-Impact",
				"Defog",
				"Captivate",
				"Bug-Bite",
				"Double-Hit",
				"Ominous-Wind",
				"Round",
				"Quick-Guard",
				"Struggle-Bug",
				"Confide",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion
}