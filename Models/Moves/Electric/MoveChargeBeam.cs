using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has a 70% chance to raise the user's Special Attack by one stage.
	public class MoveChargeBeam : Move
	{
		public MoveChargeBeam() : base(
			"Charge-Beam",
			Electric.Instance, // Move Type
			MoveCategory.Special, // Move Category
			10, 50,// PP & Pow
			90, 0 // Acc & Priority
		) {}
	}
}