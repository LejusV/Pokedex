using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Cannot lower the target's HP below 1.
	public class MoveFalseSwipe : Move
	{
		public MoveFalseSwipe() : base(
			"False-Swipe",
			Normal.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			40, 40,// PP & Pow
			1.0, 0 // Acc & Priority
		) {}
	}
}