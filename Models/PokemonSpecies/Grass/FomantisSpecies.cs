using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Fomantis Species to store common natural stats of all Fomantiss
	#region FomantisSpecies
	public class FomantisSpecies : PokemonSpecies
	{
#nullable enable
		private static FomantisSpecies? _instance = null;
#nullable restore
        public static FomantisSpecies Instance => _instance ?? (_instance = new FomantisSpecies());

		#region FomantisSpecies Constructor
		public FomantisSpecies() : base(
			753,
			"Fomantis",
			Grass.Instance,
			0.3,
			1.5,
			new PokemonStats(
				40, // HPs
				55, 35, // Attack & Defense
				50, 35, // Spacial Attack & Defense
				35 // Speed
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
				"Growth",
				"Razor-Leaf",
				"Solar-Beam",
				"Toxic",
				"Double-Team",
				"Leech-Life",
				"Rest",
				"Slash",
				"Substitute",
				"Protect",
				"Giga-Drain",
				"False-Swipe",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Sweet-Scent",
				"Synthesis",
				"Hidden-Power",
				"Sunny-Day",
				"Facade",
				"Nature-Power",
				"Ingrain",
				"Weather-Ball",
				"Aromatherapy",
				"Leaf-Blade",
				"Payback",
				"Fling",
				"Poison-Jab",
				"X-Scissor",
				"Energy-Ball",
				"Defog",
				"Leaf-Storm",
				"Grass-Knot",
				"Round",
				"Confide",
				"Leafage"
			};
		}
		#endregion
	}
	#endregion
}