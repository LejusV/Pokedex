using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Lilligant Species to store common natural stats of all Lilligants
	#region LilligantSpecies
	public class LilligantSpecies : PokemonSpecies
	{
#nullable enable
		private static LilligantSpecies? _instance = null;
#nullable restore
        public static LilligantSpecies Instance => _instance ?? (_instance = new LilligantSpecies());

		#region LilligantSpecies Constructor
		public LilligantSpecies() : base(
			549,
			"Lilligant",
			Grass.Instance,
			1.1,
			16.3,
			new PokemonStats(
				70, // HPs
				60, 75, // Attack & Defense
				110, 75, // Spacial Attack & Defense
				90 // Speed
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
				"Hyper-Beam",
				"Mega-Drain",
				"Leech-Seed",
				"Growth",
				"Solar-Beam",
				"Petal-Dance",
				"Toxic",
				"Double-Team",
				"Light-Screen",
				"Dream-Eater",
				"Flash",
				"Rest",
				"Substitute",
				"Snore",
				"Protect",
				"Giga-Drain",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Heal-Bell",
				"Return",
				"Frustration",
				"Safeguard",
				"Synthesis",
				"Hidden-Power",
				"Sunny-Day",
				"Facade",
				"Nature-Power",
				"Helping-Hand",
				"Role-Play",
				"Secret-Power",
				"Teeter-Dance",
				"Covet",
				"Worry-Seed",
				"Seed-Bomb",
				"Energy-Ball",
				"Giga-Impact",
				"Grass-Knot",
				"Quiver-Dance",
				"After-You",
				"Round",
				"Petal-Blizzard",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}