using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Excadrill Species to store common natural stats of all Excadrills
	#region ExcadrillSpecies
	public class ExcadrillSpecies : PokemonSpecies
	{
#nullable enable
		private static ExcadrillSpecies? _instance = null;
#nullable restore
        public static ExcadrillSpecies Instance => _instance ?? (_instance = new ExcadrillSpecies());

		#region ExcadrillSpecies Constructor
		public ExcadrillSpecies() : base(
			530,
			"Excadrill",
			Ground.Instance, Steel.Instance,
			0.7,
			40.4,
			new PokemonStats(
				110, // HPs
				135, 60, // Attack & Defense
				50, 65, // Spacial Attack & Defense
				88 // Speed
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
				"Horn-Drill",
				"Hyper-Beam",
				"Strength",
				"Earthquake",
				"Fissure",
				"Dig",
				"Toxic",
				"Double-Team",
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
				"Rock-Tomb",
				"Aerial-Ace",
				"Iron-Defense",
				"Fling",
				"Magnet-Rise",
				"Poison-Jab",
				"X-Scissor",
				"Focus-Blast",
				"Earth-Power",
				"Giga-Impact",
				"Shadow-Claw",
				"Iron-Head",
				"Stealth-Rock",
				"Hone-Claws",
				"Round",
				"Bulldoze",
				"Drill-Run",
				"Rototiller",
				"Confide",
				"Smart-Strike",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion
}