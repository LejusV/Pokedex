using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Sunflora Species to store common natural stats of all Sunfloras
	#region SunfloraSpecies
	public class SunfloraSpecies : PokemonSpecies
	{
#nullable enable
		private static SunfloraSpecies? _instance = null;
#nullable restore
        public static SunfloraSpecies Instance => _instance ?? (_instance = new SunfloraSpecies());

		#region SunfloraSpecies Constructor
		public SunfloraSpecies() : base(
			192,
			"Sunflora",
			Grass.Instance,
			0.8,
			8.5,
			new PokemonStats(
				75, // HPs
				75, 55, // Attack & Defense
				105, 85, // Spacial Attack & Defense
				30 // Speed
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
				"Pound",
				"Swords-Dance",
				"Cut",
				"Double-Edge",
				"Hyper-Beam",
				"Absorb",
				"Mega-Drain",
				"Leech-Seed",
				"Growth",
				"Razor-Leaf",
				"Solar-Beam",
				"Petal-Dance",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Light-Screen",
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
				"Helping-Hand",
				"Ingrain",
				"Endeavor",
				"Secret-Power",
				"Grass-Whistle",
				"Bullet-Seed",
				"Natural-Gift",
				"Worry-Seed",
				"Seed-Bomb",
				"Energy-Ball",
				"Earth-Power",
				"Giga-Impact",
				"Leaf-Storm",
				"Captivate",
				"Grass-Knot",
				"After-You",
				"Round",
				"Petal-Blizzard",
				"Flower-Shield",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}