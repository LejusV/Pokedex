using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Gurdurr Species to store common natural stats of all Gurdurrs
	#region GurdurrSpecies
	public class GurdurrSpecies : PokemonSpecies
	{
#nullable enable
		private static GurdurrSpecies? _instance = null;
#nullable restore
        public static GurdurrSpecies Instance => _instance ?? (_instance = new GurdurrSpecies());

		#region GurdurrSpecies Constructor
		public GurdurrSpecies() : base(
			533,
			"Gurdurr",
			Fighting.Instance,
			1.2,
			40.0,
			new PokemonStats(
				85, // HPs
				105, 85, // Attack & Defense
				40, 50, // Spacial Attack & Defense
				40 // Speed
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
				"Low-Kick",
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
				"Stone-Edge",
				"Grass-Knot",
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