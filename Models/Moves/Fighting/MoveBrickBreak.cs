using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Destroys Reflect and Light Screen.
	public class MoveBrickBreak : Move
	{
		public MoveBrickBreak() : base(
			"Brick-Break",
			Fighting.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			15, 75,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}