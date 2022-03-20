using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Servine Species to store common natural stats of all Servines
	#region ServineSpecies
	public class ServineSpecies : PokemonSpecies
	{
#nullable enable
		private static ServineSpecies? _instance = null;
#nullable restore
        public static ServineSpecies Instance => _instance ?? (_instance = new ServineSpecies());

		#region ServineSpecies Constructor
		public ServineSpecies() : base(
			496,
			"Servine",
			Grass.Instance,
			0.8,
			16.0,
			new PokemonStats(
				60, // HPs
				60, 75, // Attack & Defense
				60, 75, // Spacial Attack & Defense
				83 // Speed
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
				"Bind",
				"Slam",
				"Vine-Whip",
				"Tackle",
				"Wrap",
				"Leer",
				"Mega-Drain",
				"Leech-Seed",
				"Growth",
				"Solar-Beam",
				"Toxic",
				"Double-Team",
				"Light-Screen",
				"Reflect",
				"Flash",
				"Rest",
				"Substitute",
				"Snore",
				"Protect",
				"Giga-Drain",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Iron-Tail",
				"Synthesis",
				"Hidden-Power",
				"Sunny-Day",
				"Torment",
				"Facade",
				"Nature-Power",
				"Taunt",
				"Knock-Off",
				"Snatch",
				"Secret-Power",
				"Aerial-Ace",
				"Calm-Mind",
				"Leaf-Blade",
				"Wring-Out",
				"Gastro-Acid",
				"Worry-Seed",
				"Aqua-Tail",
				"Seed-Bomb",
				"Energy-Ball",
				"Leaf-Storm",
				"Grass-Knot",
				"Coil",
				"Round",
				"Grass-Pledge",
				"Work-Up",
				"Leaf-Tornado",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}