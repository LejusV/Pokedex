using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Sawk Species to store common natural stats of all Sawks
	#region SawkSpecies
	public class SawkSpecies : PokemonSpecies
	{
#nullable enable
		private static SawkSpecies? _instance = null;
#nullable restore
        public static SawkSpecies Instance => _instance ?? (_instance = new SawkSpecies());

		#region SawkSpecies Constructor
		public SawkSpecies() : base(
			539,
			"Sawk",
			Fighting.Instance,
			1.4,
			51.0,
			new PokemonStats(
				75, // HPs
				125, 75, // Attack & Defense
				30, 75, // Spacial Attack & Defense
				85 // Speed
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
				"Karate-Chop",
				"Fire-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Double-Kick",
				"Leer",
				"Low-Kick",
				"Counter",
				"Strength",
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
				"Reversal",
				"Protect",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pain-Split",
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
				"Close-Combat",
				"Payback",
				"Fling",
				"Poison-Jab",
				"Focus-Blast",
				"Giga-Impact",
				"Zen-Headbutt",
				"Stone-Edge",
				"Grass-Knot",
				"Low-Sweep",
				"Round",
				"Quick-Guard",
				"Retaliate",
				"Bulldoze",
				"Work-Up",
				"Dual-Chop",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion
}