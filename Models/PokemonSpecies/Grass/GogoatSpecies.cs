using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Gogoat Species to store common natural stats of all Gogoats
	#region GogoatSpecies
	public class GogoatSpecies : PokemonSpecies
	{
#nullable enable
		private static GogoatSpecies? _instance = null;
#nullable restore
        public static GogoatSpecies Instance => _instance ?? (_instance = new GogoatSpecies());

		#region GogoatSpecies Constructor
		public GogoatSpecies() : base(
			673,
			"Gogoat",
			Grass.Instance,
			1.7,
			91.0,
			new PokemonStats(
				123, // HPs
				100, 62, // Attack & Defense
				97, 81, // Spacial Attack & Defense
				68 // Speed
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
				"Hyper-Beam",
				"Strength",
				"Leech-Seed",
				"Growth",
				"Razor-Leaf",
				"Solar-Beam",
				"Earthquake",
				"Dig",
				"Toxic",
				"Double-Team",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Protect",
				"Giga-Drain",
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
				"Superpower",
				"Brick-Break",
				"Secret-Power",
				"Aerial-Ace",
				"Bulk-Up",
				"Bounce",
				"Leaf-Blade",
				"Payback",
				"Worry-Seed",
				"Seed-Bomb",
				"Energy-Ball",
				"Giga-Impact",
				"Zen-Headbutt",
				"Grass-Knot",
				"Round",
				"Retaliate",
				"Bulldoze",
				"Work-Up",
				"Wild-Charge",
				"Horn-Leech",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}