using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Foongus Species to store common natural stats of all Foonguss
	#region FoongusSpecies
	public class FoongusSpecies : PokemonSpecies
	{
#nullable enable
		private static FoongusSpecies? _instance = null;
#nullable restore
        public static FoongusSpecies Instance => _instance ?? (_instance = new FoongusSpecies());

		#region FoongusSpecies Constructor
		public FoongusSpecies() : base(
			590,
			"Foongus",
			Grass.Instance, Poison.Instance,
			0.2,
			1.0,
			new PokemonStats(
				69, // HPs
				55, 45, // Attack & Defense
				55, 55, // Spacial Attack & Defense
				15 // Speed
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
				"Body-Slam",
				"Absorb",
				"Mega-Drain",
				"Growth",
				"Solar-Beam",
				"Poison-Powder",
				"Stun-Spore",
				"Toxic",
				"Double-Team",
				"Defense-Curl",
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
				"Endure",
				"Rollout",
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