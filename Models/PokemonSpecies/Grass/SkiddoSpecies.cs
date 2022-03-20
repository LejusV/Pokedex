using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Skiddo Species to store common natural stats of all Skiddos
	#region SkiddoSpecies
	public class SkiddoSpecies : PokemonSpecies
	{
#nullable enable
		private static SkiddoSpecies? _instance = null;
#nullable restore
        public static SkiddoSpecies Instance => _instance ?? (_instance = new SkiddoSpecies());

		#region SkiddoSpecies Constructor
		public SkiddoSpecies() : base(
			672,
			"Skiddo",
			Grass.Instance,
			0.9,
			31.0,
			new PokemonStats(
				66, // HPs
				65, 48, // Attack & Defense
				62, 57, // Spacial Attack & Defense
				52 // Speed
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
				"Vine-Whip",
				"Tackle",
				"Take-Down",
				"Double-Edge",
				"Tail-Whip",
				"Roar",
				"Surf",
				"Strength",
				"Leech-Seed",
				"Growth",
				"Razor-Leaf",
				"Solar-Beam",
				"Dig",
				"Toxic",
				"Double-Team",
				"Defense-Curl",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Protect",
				"Giga-Drain",
				"Rollout",
				"Swagger",
				"Milk-Drink",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Synthesis",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Rock-Smash",
				"Facade",
				"Nature-Power",
				"Brick-Break",
				"Secret-Power",
				"Bulk-Up",
				"Leaf-Blade",
				"Payback",
				"Worry-Seed",
				"Seed-Bomb",
				"Energy-Ball",
				"Zen-Headbutt",
				"Grass-Knot",
				"Round",
				"Retaliate",
				"Bulldoze",
				"Work-Up",
				"Wild-Charge",
				"Horn-Leech",
				"Grassy-Terrain",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}