using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Has a 30% chance to make the target flinch.
	public class MoveAstonish : Move
	{
		public MoveAstonish() : base(
			"Astonish",
			Ghost.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			15, 30,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}