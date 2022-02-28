using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Has a 10% chance to confuse the target.
	public class MoveConfusion : Move
	{
		public MoveConfusion() : base(
			"Confusion",
			Psychic.Instance, // Move Type
			MoveCategory.Special, // Move Category
			25, 50,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}