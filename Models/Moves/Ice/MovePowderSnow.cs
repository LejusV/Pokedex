using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Has a 10% chance to freeze the target.
	public class MovePowderSnow : Move
	{
		public MovePowderSnow() : base(
			"Powder-Snow",
			Ice.Instance, // Move Type
			MoveCategory.Special, // Move Category
			25, 40,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}