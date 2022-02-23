using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Raises the Defense and Special Defense of all friendly Pokémon with plus or minus by one stage.
	public class MoveMagneticFlux : Move
	{
		public MoveMagneticFlux() : base(
			"Magnetic-Flux",
			Electric.Instance, // Move Type
			MoveCategory.Status, // Move Category
			20, null,// PP & Pow
			null, 0 // Acc & Priority
			
		) {}
	}
}