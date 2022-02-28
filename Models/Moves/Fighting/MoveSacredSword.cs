using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Ignores the target's stat modifiers.
	public class MoveSacredSword : Move
	{
		public MoveSacredSword() : base(
			"Sacred-Sword",
			Fighting.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			15, 90,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}