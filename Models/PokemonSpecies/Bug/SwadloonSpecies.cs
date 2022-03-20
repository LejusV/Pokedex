using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Swadloon Species to store common natural stats of all Swadloons
	#region SwadloonSpecies
	public class SwadloonSpecies : PokemonSpecies
	{
#nullable enable
		private static SwadloonSpecies? _instance = null;
#nullable restore
        public static SwadloonSpecies Instance => _instance ?? (_instance = new SwadloonSpecies());

		#region SwadloonSpecies Constructor
		public SwadloonSpecies() : base(
			541,
			"Swadloon",
			Bug.Instance, Grass.Instance,
			0.5,
			7.3,
			new PokemonStats(
				55, // HPs
				63, 90, // Attack & Defense
				50, 80, // Spacial Attack & Defense
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
				"Cut",
				"Tackle",
				"Razor-Leaf",
				"Solar-Beam",
				"String-Shot",
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
				"Return",
				"Frustration",
				"Safeguard",
				"Synthesis",
				"Hidden-Power",
				"Sunny-Day",
				"Facade",
				"Nature-Power",
				"Magic-Coat",
				"Secret-Power",
				"Grass-Whistle",
				"Signal-Beam",
				"Iron-Defense",
				"Calm-Mind",
				"Payback",
				"Worry-Seed",
				"Seed-Bomb",
				"Energy-Ball",
				"Grass-Knot",
				"Bug-Bite",
				"Round",
				"Struggle-Bug",
				"Electroweb",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}