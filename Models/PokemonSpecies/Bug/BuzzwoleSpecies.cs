using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Buzzwole Species to store common natural stats of all Buzzwoles
	#region BuzzwoleSpecies
	public class BuzzwoleSpecies : PokemonSpecies
	{
#nullable enable
		private static BuzzwoleSpecies? _instance = null;
#nullable restore
        public static BuzzwoleSpecies Instance => _instance ?? (_instance = new BuzzwoleSpecies());

		#region BuzzwoleSpecies Constructor
		public BuzzwoleSpecies() : base(
			794,
			"Buzzwole",
			Bug.Instance, Fighting.Instance,
			2.4,
			333.6,
			new PokemonStats(
				107, // HPs
				139, 139, // Attack & Defense
				53, 53, // Spacial Attack & Defense
				79 // Speed
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
				"Comet-Punch",
				"Mega-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Counter",
				"Earthquake",
				"Toxic",
				"Double-Team",
				"Harden",
				"Focus-Energy",
				"Leech-Life",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Reversal",
				"Protect",
				"Endure",
				"False-Swipe",
				"Swagger",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Dynamic-Punch",
				"Vital-Throw",
				"Hidden-Power",
				"Facade",
				"Focus-Punch",
				"Taunt",
				"Superpower",
				"Brick-Break",
				"Rock-Tomb",
				"Bulk-Up",
				"Roost",
				"Hammer-Arm",
				"Gyro-Ball",
				"Payback",
				"Fling",
				"Poison-Jab",
				"Giga-Impact",
				"Stone-Edge",
				"Smack-Down",
				"Low-Sweep",
				"Round",
				"Bulldoze",
				"Work-Up",
				"Fell-Stinger",
				"Confide",
				"Power-Up-Punch",
				"Lunge"
			};
		}
		#endregion
	}
	#endregion
}