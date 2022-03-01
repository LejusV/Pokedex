using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Has a 30% chance to poison the target.
	public class MoveSludgeBomb : Move
	{
		public MoveSludgeBomb() : base(
			"Sludge-Bomb",
			Poison.Instance, // Move Type
			MoveCategory.Special, // Move Category
			10, 90,// PP & Pow
			1.0, 0 // Acc & Priority
		) {}
	}
}