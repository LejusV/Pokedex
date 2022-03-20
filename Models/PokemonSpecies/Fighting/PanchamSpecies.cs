using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Pancham Species to store common natural stats of all Panchams
	#region PanchamSpecies
	public class PanchamSpecies : PokemonSpecies
	{
#nullable enable
		private static PanchamSpecies? _instance = null;
#nullable restore
        public static PanchamSpecies Instance => _instance ?? (_instance = new PanchamSpecies());

		#region PanchamSpecies Constructor
		public PanchamSpecies() : base(
			674,
			"Pancham",
			Fighting.Instance,
			0.6,
			8.0,
			new PokemonStats(
				67, // HPs
				82, 62, // Attack & Defense
				46, 48, // Spacial Attack & Defense
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
				"Karate-Chop",
				"Comet-Punch",
				"Fire-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Swords-Dance",
				"Cut",
				"Tackle",
				"Body-Slam",
				"Leer",
				"Roar",
				"Surf",
				"Low-Kick",
				"Strength",
				"Dig",
				"Toxic",
				"Double-Team",
				"Rest",
				"Rock-Slide",
				"Slash",
				"Substitute",
				"Snore",
				"Spite",
				"Protect",
				"Sludge-Bomb",
				"False-Swipe",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Vital-Throw",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Crunch",
				"Rock-Smash",
				"Uproar",
				"Torment",
				"Facade",
				"Focus-Punch",
				"Helping-Hand",
				"Superpower",
				"Brick-Break",
				"Knock-Off",
				"Endeavor",
				"Snatch",
				"Secret-Power",
				"Arm-Thrust",
				"Hyper-Voice",
				"Rock-Tomb",
				"Sky-Uppercut",
				"Aerial-Ace",
				"Block",
				"Bulk-Up",
				"Covet",
				"Payback",
				"Fling",
				"Me-First",
				"Dark-Pulse",
				"Drain-Punch",
				"Shadow-Claw",
				"Zen-Headbutt",
				"Gunk-Shot",
				"Iron-Head",
				"Stone-Edge",
				"Grass-Knot",
				"Storm-Throw",
				"Low-Sweep",
				"Foul-Play",
				"Entrainment",
				"Round",
				"Echoed-Voice",
				"Quick-Guard",
				"Circle-Throw",
				"Quash",
				"Retaliate",
				"Bulldoze",
				"Work-Up",
				"Dual-Chop",
				"Parting-Shot",
				"Confide",
				"Power-Up-Punch",
				"Power-Trip"
			};
		}
		#endregion
	}
	#endregion
}