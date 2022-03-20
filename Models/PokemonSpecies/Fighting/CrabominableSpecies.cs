using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Crabominable Species to store common natural stats of all Crabominables
	#region CrabominableSpecies
	public class CrabominableSpecies : PokemonSpecies
	{
#nullable enable
		private static CrabominableSpecies? _instance = null;
#nullable restore
        public static CrabominableSpecies Instance => _instance ?? (_instance = new CrabominableSpecies());

		#region CrabominableSpecies Constructor
		public CrabominableSpecies() : base(
			740,
			"Crabominable",
			Fighting.Instance, Ice.Instance,
			1.7,
			180.0,
			new PokemonStats(
				97, // HPs
				132, 77, // Attack & Defense
				62, 67, // Spacial Attack & Defense
				43 // Speed
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
				"Leer",
				"Ice-Beam",
				"Blizzard",
				"Bubble-Beam",
				"Earthquake",
				"Toxic",
				"Double-Team",
				"Bubble",
				"Dizzy-Punch",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Thief",
				"Reversal",
				"Protect",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Dynamic-Punch",
				"Pursuit",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Rock-Smash",
				"Hail",
				"Facade",
				"Brick-Break",
				"Rock-Tomb",
				"Iron-Defense",
				"Bulk-Up",
				"Close-Combat",
				"Payback",
				"Fling",
				"Focus-Blast",
				"Giga-Impact",
				"Avalanche",
				"Stone-Edge",
				"Round",
				"Scald",
				"Bulldoze",
				"Frost-Breath",
				"Work-Up",
				"Confide",
				"Power-Up-Punch",
				"Ice-Hammer",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion
}