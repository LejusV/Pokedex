using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Amoonguss Species to store common natural stats of all Amoongusss
	#region AmoongussSpecies
	public class AmoongussSpecies : PokemonSpecies
	{
#nullable enable
		private static AmoongussSpecies? _instance = null;
#nullable restore
        public static AmoongussSpecies Instance => _instance ?? (_instance = new AmoongussSpecies());

		#region AmoongussSpecies Constructor
		public AmoongussSpecies() : base(
			591,
			"Amoonguss",
			Grass.Instance, Poison.Instance,
			0.6,
			10.5,
			new PokemonStats(
				114, // HPs
				85, 70, // Attack & Defense
				85, 80, // Spacial Attack & Defense
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
				"Hyper-Beam",
				"Absorb",
				"Mega-Drain",
				"Growth",
				"Solar-Beam",
				"Toxic",
				"Double-Team",
				"Bide",
				"Spore",
				"Flash",
				"Rest",
				"Substitute",
				"Snore",
				"Protect",
				"Feint-Attack",
				"Sludge-Bomb",
				"Giga-Drain",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Sweet-Scent",
				"Synthesis",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Facade",
				"Nature-Power",
				"Ingrain",
				"Secret-Power",
				"Astonish",
				"Payback",
				"Gastro-Acid",
				"Worry-Seed",
				"Seed-Bomb",
				"Energy-Ball",
				"Giga-Impact",
				"Grass-Knot",
				"Venoshock",
				"Rage-Powder",
				"Foul-Play",
				"After-You",
				"Round",
				"Clear-Smog",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}