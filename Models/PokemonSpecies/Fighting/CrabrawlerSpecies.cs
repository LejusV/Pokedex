using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Crabrawler Species to store common natural stats of all Crabrawlers
	#region CrabrawlerSpecies
	public class CrabrawlerSpecies : PokemonSpecies
	{
#nullable enable
		private static CrabrawlerSpecies? _instance = null;
#nullable restore
        public static CrabrawlerSpecies Instance => _instance ?? (_instance = new CrabrawlerSpecies());

		#region CrabrawlerSpecies Constructor
		public CrabrawlerSpecies() : base(
			739,
			"Crabrawler",
			Fighting.Instance,
			0.6,
			7.0,
			new PokemonStats(
				47, // HPs
				82, 57, // Attack & Defense
				42, 47, // Spacial Attack & Defense
				63 // Speed
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
				"Leer",
				"Bubble-Beam",
				"Earthquake",
				"Toxic",
				"Double-Team",
				"Amnesia",
				"Bubble",
				"Dizzy-Punch",
				"Crabhammer",
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
				"Facade",
				"Superpower",
				"Brick-Break",
				"Endeavor",
				"Rock-Tomb",
				"Iron-Defense",
				"Bulk-Up",
				"Close-Combat",
				"Payback",
				"Fling",
				"Focus-Blast",
				"Stone-Edge",
				"Wide-Guard",
				"Round",
				"Scald",
				"Bulldoze",
				"Frost-Breath",
				"Work-Up",
				"Confide",
				"Power-Up-Punch",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion
}