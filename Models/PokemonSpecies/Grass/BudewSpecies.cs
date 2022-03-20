using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Budew Species to store common natural stats of all Budews
	#region BudewSpecies
	public class BudewSpecies : PokemonSpecies
	{
#nullable enable
		private static BudewSpecies? _instance = null;
#nullable restore
        public static BudewSpecies Instance => _instance ?? (_instance = new BudewSpecies());

		#region BudewSpecies Constructor
		public BudewSpecies() : base(
			406,
			"Budew",
			Grass.Instance, Poison.Instance,
			0.2,
			1.2,
			new PokemonStats(
				40, // HPs
				30, 35, // Attack & Defense
				50, 70, // Spacial Attack & Defense
				55 // Speed
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
				"Pin-Missile",
				"Absorb",
				"Mega-Drain",
				"Growth",
				"Razor-Leaf",
				"Solar-Beam",
				"Stun-Spore",
				"Sleep-Powder",
				"Toxic",
				"Double-Team",
				"Swift",
				"Flash",
				"Rest",
				"Substitute",
				"Mind-Reader",
				"Snore",
				"Cotton-Spore",
				"Protect",
				"Sludge-Bomb",
				"Mud-Slap",
				"Spikes",
				"Giga-Drain",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Synthesis",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Uproar",
				"Facade",
				"Nature-Power",
				"Secret-Power",
				"Grass-Whistle",
				"Extrasensory",
				"Bullet-Seed",
				"Covet",
				"Water-Sport",
				"Natural-Gift",
				"Worry-Seed",
				"Seed-Bomb",
				"Energy-Ball",
				"Leaf-Storm",
				"Captivate",
				"Grass-Knot",
				"Venoshock",
				"Round",
				"Confide",
				"Dazzling-Gleam"
			};
		}
		#endregion
	}
	#endregion
}