using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Wormadam-Plant Species to store common natural stats of all Wormadam-Plants
	#region Wormadam-PlantSpecies
	public class WormadamPlantSpecies : PokemonSpecies
	{
#nullable enable
		private static WormadamPlantSpecies? _instance = null;
#nullable restore
        public static WormadamPlantSpecies Instance => _instance ?? (_instance = new WormadamPlantSpecies());

		#region Wormadam-PlantSpecies Constructor
		public WormadamPlantSpecies() : base(
			413,
			"Wormadam-Plant",
			Bug.Instance, Grass.Instance,
			0.5,
			6.5,
			new PokemonStats(
				60, // HPs
				59, 85, // Attack & Defense
				79, 105, // Spacial Attack & Defense
				36 // Speed
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
				"Tackle",
				"Psybeam",
				"Hyper-Beam",
				"Growth",
				"Razor-Leaf",
				"Solar-Beam",
				"String-Shot",
				"Toxic",
				"Confusion",
				"Psychic",
				"Double-Team",
				"Dream-Eater",
				"Flash",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Flail",
				"Protect",
				"Giga-Drain",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Synthesis",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Uproar",
				"Facade",
				"Endeavor",
				"Skill-Swap",
				"Secret-Power",
				"Signal-Beam",
				"Bullet-Seed",
				"Natural-Gift",
				"Worry-Seed",
				"Sucker-Punch",
				"Seed-Bomb",
				"Bug-Buzz",
				"Energy-Ball",
				"Giga-Impact",
				"Leaf-Storm",
				"Captivate",
				"Grass-Knot",
				"Bug-Bite",
				"Venoshock",
				"Quiver-Dance",
				"Round",
				"Struggle-Bug",
				"Electroweb",
				"Confide",
				"Infestation"
			};
		}
		#endregion
	}
	#endregion
}