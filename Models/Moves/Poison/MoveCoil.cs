using Pokedex.Enums;
using Pokedex.Models.PokeTypes;

namespace Pokedex.Models.Moves
{
	//Raises the user's Attack, Defense, and accuracy by one stage each.
	public class MoveCoil : Move
	{
		public MoveCoil() : base(
			"Coil",
			Poison.Instance, // Move Type
			MoveCategory.Status, // Move Category
			20, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}