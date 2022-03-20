using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Sewaddle Species to store common natural stats of all Sewaddles
	#region SewaddleSpecies
	public class SewaddleSpecies : PokemonSpecies
	{
#nullable enable
		private static SewaddleSpecies? _instance = null;
#nullable restore
        public static SewaddleSpecies Instance => _instance ?? (_instance = new SewaddleSpecies());

		#region SewaddleSpecies Constructor
		public SewaddleSpecies() : base(
			540,
			"Sewaddle",
			Bug.Instance, Grass.Instance,
			0.3,
			2.5,
			new PokemonStats(
				45, // HPs
				53, 70, // Attack & Defense
				40, 60, // Spacial Attack & Defense
				42 // Speed
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
				"Razor-Wind",
				"Cut",
				"Tackle",
				"Razor-Leaf",
				"Solar-Beam",
				"String-Shot",
				"Toxic",
				"Agility",
				"Screech",
				"Double-Team",
				"Light-Screen",
				"Dream-Eater",
				"Flash",
				"Rest",
				"Substitute",
				"Mind-Reader",
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
				"Baton-Pass",
				"Synthesis",
				"Hidden-Power",
				"Sunny-Day",
				"Facade",
				"Nature-Power",
				"Magic-Coat",
				"Secret-Power",
				"Camouflage",
				"Silver-Wind",
				"Signal-Beam",
				"Iron-Defense",
				"Calm-Mind",
				"Payback",
				"Me-First",
				"Worry-Seed",
				"Seed-Bomb",
				"Air-Slash",
				"Bug-Buzz",
				"Energy-Ball",
				"Grass-Knot",
				"Bug-Bite",
				"Round",
				"Struggle-Bug",
				"Electroweb",
				"Sticky-Web",
				"Grassy-Terrain",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}