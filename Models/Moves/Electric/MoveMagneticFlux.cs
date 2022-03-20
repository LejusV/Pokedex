using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Raises the Defense and Special Defense of all friendly Pokémon with plus or minus by one stage.
	public class MoveMagneticFlux : Move
	{
#nullable enable
		private static MoveMagneticFlux? _instance = null;
#nullable restore
        public static MoveMagneticFlux Instance => _instance ?? (_instance = new MoveMagneticFlux());

		public MoveMagneticFlux() : base(
			"Magnetic-Flux",
			Electric.Instance, // Move Type
			MoveCategory.Status, // Move Category
			20, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}