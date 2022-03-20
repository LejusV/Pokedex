using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Throh Species to store common natural stats of all Throhs
	#region ThrohSpecies
	public class ThrohSpecies : PokemonSpecies
	{
#nullable enable
		private static ThrohSpecies? _instance = null;
#nullable restore
        public static ThrohSpecies Instance => _instance ?? (_instance = new ThrohSpecies());

		#region ThrohSpecies Constructor
		public ThrohSpecies() : base(
			538,
			"Throh",
			Fighting.Instance,
			1.3,
			55.5,
			new PokemonStats(
				120, // HPs
				100, 85, // Attack & Defense
				30, 85, // Spacial Attack & Defense
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
				"Fire-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Bind",
				"Body-Slam",
				"Leer",
				"Low-Kick",
				"Seismic-Toss",
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
				"Vital-Throw",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Rock-Smash",
				"Facade",
				"Focus-Punch",
				"Taunt",
				"Helping-Hand",
				"Superpower",
				"Revenge",
				"Brick-Break",
				"Knock-Off",
				"Secret-Power",
				"Rock-Tomb",
				"Block",
				"Bulk-Up",
				"Payback",
				"Fling",
				"Poison-Jab",
				"Focus-Blast",
				"Giga-Impact",
				"Zen-Headbutt",
				"Stone-Edge",
				"Grass-Knot",
				"Wide-Guard",
				"Storm-Throw",
				"Low-Sweep",
				"Round",
				"Circle-Throw",
				"Retaliate",
				"Bulldoze",
				"Work-Up",
				"Mat-Block",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion
}