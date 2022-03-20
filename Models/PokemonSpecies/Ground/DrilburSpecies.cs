using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Drilbur Species to store common natural stats of all Drilburs
	#region DrilburSpecies
	public class DrilburSpecies : PokemonSpecies
	{
#nullable enable
		private static DrilburSpecies? _instance = null;
#nullable restore
        public static DrilburSpecies Instance => _instance ?? (_instance = new DrilburSpecies());

		#region DrilburSpecies Constructor
		public DrilburSpecies() : base(
			529,
			"Drilbur",
			Ground.Instance,
			0.3,
			8.5,
			new PokemonStats(
				60, // HPs
				85, 40, // Attack & Defense
				30, 45, // Spacial Attack & Defense
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
				"Submission",
				"Strength",
				"Earthquake",
				"Fissure",
				"Dig",
				"Toxic",
				"Double-Team",
				"Skull-Bash",
				"Fury-Swipes",
				"Rest",
				"Rock-Slide",
				"Slash",
				"Substitute",
				"Snore",
				"Protect",
				"Sludge-Bomb",
				"Mud-Slap",
				"Sandstorm",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Rapid-Spin",
				"Metal-Claw",
				"Hidden-Power",
				"Rock-Smash",
				"Facade",
				"Brick-Break",
				"Secret-Power",
				"Mud-Sport",
				"Crush-Claw",
				"Rock-Tomb",
				"Metal-Sound",
				"Aerial-Ace",
				"Iron-Defense",
				"Fling",
				"Poison-Jab",
				"X-Scissor",
				"Earth-Power",
				"Shadow-Claw",
				"Rock-Climb",
				"Stealth-Rock",
				"Hone-Claws",
				"Round",
				"Bulldoze",
				"Drill-Run",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}