using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Cherrim Species to store common natural stats of all Cherrims
	#region CherrimSpecies
	public class CherrimSpecies : PokemonSpecies
	{
#nullable enable
		private static CherrimSpecies? _instance = null;
#nullable restore
        public static CherrimSpecies Instance => _instance ?? (_instance = new CherrimSpecies());

		#region CherrimSpecies Constructor
		public CherrimSpecies() : base(
			421,
			"Cherrim",
			Grass.Instance,
			0.5,
			9.3,
			new PokemonStats(
				70, // HPs
				60, 70, // Attack & Defense
				87, 78, // Spacial Attack & Defense
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
				"Swords-Dance",
				"Tackle",
				"Take-Down",
				"Hyper-Beam",
				"Leech-Seed",
				"Growth",
				"Solar-Beam",
				"Petal-Dance",
				"Toxic",
				"Double-Team",
				"Flash",
				"Rest",
				"Substitute",
				"Snore",
				"Protect",
				"Giga-Drain",
				"Endure",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Morning-Sun",
				"Synthesis",
				"Hidden-Power",
				"Sunny-Day",
				"Facade",
				"Nature-Power",
				"Helping-Hand",
				"Secret-Power",
				"Bullet-Seed",
				"Magical-Leaf",
				"Natural-Gift",
				"Lucky-Chant",
				"Worry-Seed",
				"Seed-Bomb",
				"Energy-Ball",
				"Giga-Impact",
				"Captivate",
				"Grass-Knot",
				"Round",
				"Petal-Blizzard",
				"Confide",
				"Dazzling-Gleam"
			};
		}
		#endregion
	}
	#endregion
}