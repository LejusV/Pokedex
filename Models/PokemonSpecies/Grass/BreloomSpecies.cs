using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Breloom Species to store common natural stats of all Brelooms
	#region BreloomSpecies
	public class BreloomSpecies : PokemonSpecies
	{
#nullable enable
		private static BreloomSpecies? _instance = null;
#nullable restore
        public static BreloomSpecies Instance => _instance ?? (_instance = new BreloomSpecies());

		#region BreloomSpecies Constructor
		public BreloomSpecies() : base(
			286,
			"Breloom",
			Grass.Instance, Fighting.Instance,
			1.2,
			39.2,
			new PokemonStats(
				60, // HPs
				130, 80, // Attack & Defense
				60, 60, // Spacial Attack & Defense
				70 // Speed
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
				"Mega-Punch",
				"Thunder-Punch",
				"Swords-Dance",
				"Cut",
				"Mega-Kick",
				"Headbutt",
				"Tackle",
				"Body-Slam",
				"Double-Edge",
				"Hyper-Beam",
				"Counter",
				"Seismic-Toss",
				"Strength",
				"Absorb",
				"Mega-Drain",
				"Leech-Seed",
				"Solar-Beam",
				"Stun-Spore",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Flash",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Mind-Reader",
				"Snore",
				"Protect",
				"Mach-Punch",
				"Sludge-Bomb",
				"Mud-Slap",
				"Giga-Drain",
				"Endure",
				"False-Swipe",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Dynamic-Punch",
				"Iron-Tail",
				"Synthesis",
				"Hidden-Power",
				"Sunny-Day",
				"Rock-Smash",
				"Facade",
				"Focus-Punch",
				"Helping-Hand",
				"Superpower",
				"Brick-Break",
				"Snatch",
				"Secret-Power",
				"Rock-Tomb",
				"Sky-Uppercut",
				"Bullet-Seed",
				"Bulk-Up",
				"Natural-Gift",
				"Feint",
				"Fling",
				"Worry-Seed",
				"Force-Palm",
				"Seed-Bomb",
				"Drain-Punch",
				"Vacuum-Wave",
				"Focus-Blast",
				"Energy-Ball",
				"Giga-Impact",
				"Stone-Edge",
				"Captivate",
				"Grass-Knot",
				"Venoshock",
				"Low-Sweep",
				"Round",
				"Retaliate",
				"Work-Up",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion
}