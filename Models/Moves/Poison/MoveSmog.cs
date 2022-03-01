using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Has a 40% chance to poison the target.
	public class MoveSmog : Move
	{
		public MoveSmog() : base(
			"Smog",
			Poison.Instance, // Move Type
			MoveCategory.Special, // Move Category
			20, 30,// PP & Pow
			0.7, 0 // Acc & Priority
		) {}
	}
}