using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Conkeldurr Species to store common natural stats of all Conkeldurrs
	#region ConkeldurrSpecies
	public class ConkeldurrSpecies : PokemonSpecies
	{
#nullable enable
		private static ConkeldurrSpecies? _instance = null;
#nullable restore
        public static ConkeldurrSpecies Instance => _instance ?? (_instance = new ConkeldurrSpecies());

		#region ConkeldurrSpecies Constructor
		public ConkeldurrSpecies() : base(
			534,
			"Conkeldurr",
			Fighting.Instance,
			1.4,
			87.0,
			new PokemonStats(
				105, // HPs
				140, 95, // Attack & Defense
				55, 65, // Spacial Attack & Defense
				45 // Speed
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
				"Fire-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Leer",
				"Hyper-Beam",
				"Low-Kick",
				"Strength",
				"Rock-Throw",
				"Earthquake",
				"Dig",
				"Toxic",
				"Double-Team",
				"Focus-Energy",
				"Bide",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Protect",
				"Scary-Face",
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
				"Poison-Jab",
				"Drain-Punch",
				"Focus-Blast",
				"Giga-Impact",
				"Stone-Edge",
				"Grass-Knot",
				"Smack-Down",
				"Low-Sweep",
				"Round",
				"Chip-Away",
				"Retaliate",
				"Bulldoze",
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