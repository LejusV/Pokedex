using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Scizor Species to store common natural stats of all Scizors
	#region ScizorSpecies
	public class ScizorSpecies : PokemonSpecies
	{
#nullable enable
		private static ScizorSpecies? _instance = null;
#nullable restore
        public static ScizorSpecies Instance => _instance ?? (_instance = new ScizorSpecies());

		#region ScizorSpecies Constructor
		public ScizorSpecies() : base(
			212,
			"Scizor",
			Bug.Instance, Steel.Instance,
			1.8,
			118.0,
			new PokemonStats(
				70, // HPs
				130, 100, // Attack & Defense
				55, 80, // Spacial Attack & Defense
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
				"Razor-Wind",
				"Swords-Dance",
				"Cut",
				"Headbutt",
				"Double-Edge",
				"Leer",
				"Hyper-Beam",
				"Counter",
				"Strength",
				"Toxic",
				"Agility",
				"Quick-Attack",
				"Mimic",
				"Double-Team",
				"Light-Screen",
				"Focus-Energy",
				"Swift",
				"Rest",
				"Slash",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Protect",
				"Detect",
				"Sandstorm",
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
				"Pursuit",
				"Metal-Claw",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Rock-Smash",
				"Facade",
				"Superpower",
				"Brick-Break",
				"Knock-Off",
				"Secret-Power",
				"Silver-Wind",
				"Aerial-Ace",
				"Iron-Defense",
				"Roost",
				"Natural-Gift",
				"Feint",
				"Tailwind",
				"U-Turn",
				"Fling",
				"Night-Slash",
				"X-Scissor",
				"Giga-Impact",
				"Bullet-Punch",
				"Flash-Cannon",
				"Defog",
				"Iron-Head",
				"Captivate",
				"Bug-Bite",
				"Double-Hit",
				"Ominous-Wind",
				"Venoshock",
				"Round",
				"Acrobatics",
				"Struggle-Bug",
				"Confide",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion
}