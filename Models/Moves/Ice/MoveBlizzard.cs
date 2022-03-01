using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Has a 10% chance to freeze the target.
	public class MoveBlizzard : Move
	{
		public MoveBlizzard() : base(
			"Blizzard",
			Ice.Instance, // Move Type
			MoveCategory.Special, // Move Category
			5, 110,// PP & Pow
			0.7, 0 // Acc & Priority
		) {}
	}
}