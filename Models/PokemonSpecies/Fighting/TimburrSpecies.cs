using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Timburr Species to store common natural stats of all Timburrs
	#region TimburrSpecies
	public class TimburrSpecies : PokemonSpecies
	{
#nullable enable
		private static TimburrSpecies? _instance = null;
#nullable restore
        public static TimburrSpecies Instance => _instance ?? (_instance = new TimburrSpecies());

		#region TimburrSpecies Constructor
		public TimburrSpecies() : base(
			532,
			"Timburr",
			Fighting.Instance,
			0.6,
			12.5,
			new PokemonStats(
				75, // HPs
				80, 55, // Attack & Defense
				25, 35, // Spacial Attack & Defense
				35 // Speed
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
				"Pound",
				"Comet-Punch",
				"Fire-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Leer",
				"Low-Kick",
				"Counter",
				"Strength",
				"Rock-Throw",
				"Dig",
				"Toxic",
				"Double-Team",
				"Focus-Energy",
				"Bide",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Reversal",
				"Protect",
				"Mach-Punch",
				"Scary-Face",
				"Foresight",
				"Detect",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Dynamic-Punch",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Rock-Smash",
				"Facade",
				"Focus-Punch",
				"Smelling-Salts",
				"Taunt",
				"Helping-Hand",
				"Superpower",
				"Brick-Break",
				"Knock-Off",
				"Secret-Power",
				"Rock-Tomb",
				"Block",
				"Bulk-Up",
				"Wake-Up-Slap",
				"Hammer-Arm",
				"Payback",
				"Fling",
				"Force-Palm",
				"Poison-Jab",
				"Drain-Punch",
				"Focus-Blast",
				"Stone-Edge",
				"Grass-Knot",
				"Wide-Guard",
				"Smack-Down",
				"Low-Sweep",
				"Round",
				"Chip-Away",
				"Retaliate",
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