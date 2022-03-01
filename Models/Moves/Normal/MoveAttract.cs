using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Target falls in love if it has the opposite gender, and has a 50% chance to refuse attacking the user.
	public class MoveAttract : Move
	{
		public MoveAttract() : base(
			"Attract",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			15, null,// PP & Pow
			1.0, 0 // Acc & Priority
		) {}
	}
}