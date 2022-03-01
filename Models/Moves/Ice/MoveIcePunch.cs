using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Has a 10% chance to freeze the target.
	public class MoveIcePunch : Move
	{
		public MoveIcePunch() : base(
			"Ice-Punch",
			Ice.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			15, 75,// PP & Pow
			1.0, 0 // Acc & Priority
		) {}
	}
}