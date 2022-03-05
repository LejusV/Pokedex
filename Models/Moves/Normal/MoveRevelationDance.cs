using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Has the same type as the user.
	public class MoveRevelationDance : Move
	{
		public MoveRevelationDance() : base(
			"Revelation-Dance",
			Normal.Instance, // Move Type
			MoveCategory.Special, // Move Category
			15, 90,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}