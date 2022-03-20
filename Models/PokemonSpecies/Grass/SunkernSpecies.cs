using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Sunkern Species to store common natural stats of all Sunkerns
	#region SunkernSpecies
	public class SunkernSpecies : PokemonSpecies
	{
#nullable enable
		private static SunkernSpecies? _instance = null;
#nullable restore
        public static SunkernSpecies Instance => _instance ?? (_instance = new SunkernSpecies());

		#region SunkernSpecies Constructor
		public SunkernSpecies() : base(
			191,
			"Sunkern",
			Grass.Instance,
			0.3,
			1.8,
			new PokemonStats(
				30, // HPs
				30, 30, // Attack & Defense
				30, 30, // Spacial Attack & Defense
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
				"Swords-Dance",
				"Cut",
				"Double-Edge",
				"Absorb",
				"Mega-Drain",
				"Leech-Seed",
				"Growth",
				"Razor-Leaf",
				"Solar-Beam",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Light-Screen",
				"Bide",
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
				"Encore",
				"Sweet-Scent",
				"Morning-Sun",
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
				"Captivate",
				"Grass-Knot",
				"After-You",
				"Round",
				"Grassy-Terrain",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}