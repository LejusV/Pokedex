using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Bellossom Species to store common natural stats of all Bellossoms
	#region BellossomSpecies
	public class BellossomSpecies : PokemonSpecies
	{
#nullable enable
		private static BellossomSpecies? _instance = null;
#nullable restore
        public static BellossomSpecies Instance => _instance ?? (_instance = new BellossomSpecies());

		#region BellossomSpecies Constructor
		public BellossomSpecies() : base(
			182,
			"Bellossom",
			Grass.Instance,
			0.4,
			5.8,
			new PokemonStats(
				75, // HPs
				80, 95, // Attack & Defense
				90, 100, // Spacial Attack & Defense
				50 // Speed
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
				"Swords-Dance",
				"Cut",
				"Double-Edge",
				"Hyper-Beam",
				"Absorb",
				"Mega-Drain",
				"Solar-Beam",
				"Stun-Spore",
				"Petal-Dance",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Flash",
				"Rest",
				"Substitute",
				"Snore",
				"Curse",
				"Protect",
				"Sludge-Bomb",
				"Giga-Drain",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Sweet-Scent",
				"Synthesis",
				"Hidden-Power",
				"Sunny-Day",
				"Uproar",
				"Facade",
				"Nature-Power",
				"Secret-Power",
				"Bullet-Seed",
				"Magical-Leaf",
				"Leaf-Blade",
				"Natural-Gift",
				"Fling",
				"Gastro-Acid",
				"Worry-Seed",
				"Seed-Bomb",
				"Drain-Punch",
				"Energy-Ball",
				"Giga-Impact",
				"Leaf-Storm",
				"Captivate",
				"Grass-Knot",
				"Venoshock",
				"Quiver-Dance",
				"After-You",
				"Round",
				"Petal-Blizzard",
				"Confide",
				"Dazzling-Gleam",
				"Infestation"
			};
		}
		#endregion
	}
	#endregion
}