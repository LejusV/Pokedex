using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Target cannot use held items.
	public class MoveEmbargo : Move
	{
		public MoveEmbargo() : base(
			"Embargo",
			Dark.Instance, // Move Type
			MoveCategory.Status, // Move Category
			15, null,// PP & Pow
			1.0, 0 // Acc & Priority
		) {}
	}
}