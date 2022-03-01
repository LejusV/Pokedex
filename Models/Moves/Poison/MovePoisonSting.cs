using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Has a 30% chance to poison the target.
	public class MovePoisonSting : Move
	{
		public MovePoisonSting() : base(
			"Poison-Sting",
			Poison.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			35, 15,// PP & Pow
			1.0, 0 // Acc & Priority
		) {}
	}
}