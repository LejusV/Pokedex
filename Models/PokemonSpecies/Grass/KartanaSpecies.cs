using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Kartana Species to store common natural stats of all Kartanas
	#region KartanaSpecies
	public class KartanaSpecies : PokemonSpecies
	{
#nullable enable
		private static KartanaSpecies? _instance = null;
#nullable restore
        public static KartanaSpecies Instance => _instance ?? (_instance = new KartanaSpecies());

		#region KartanaSpecies Constructor
		public KartanaSpecies() : base(
			798,
			"Kartana",
			Grass.Instance, Steel.Instance,
			0.3,
			0.1,
			new PokemonStats(
				59, // HPs
				181, 131, // Attack & Defense
				59, 31, // Spacial Attack & Defense
				109 // Speed
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
				"Guillotine",
				"Swords-Dance",
				"Cut",
				"Razor-Leaf",
				"Toxic",
				"Double-Team",
				"Rest",
				"Substitute",
				"Protect",
				"Detect",
				"False-Swipe",
				"Swagger",
				"Fury-Cutter",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Synthesis",
				"Hidden-Power",
				"Brick-Break",
				"Air-Cutter",
				"Aerial-Ace",
				"Calm-Mind",
				"Leaf-Blade",
				"Night-Slash",
				"Air-Slash",
				"X-Scissor",
				"Vacuum-Wave",
				"Giga-Impact",
				"Psycho-Cut",
				"Defog",
				"Round",
				"Sacred-Sword",
				"Confide",
				"Laser-Focus",
				"Smart-Strike"
			};
		}
		#endregion
	}
	#endregion
}