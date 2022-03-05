using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Puts the target to sleep.
	public class MoveDarkVoid : Move
	{
		public MoveDarkVoid() : base(
			"Dark-Void",
			Dark.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			50, 0 // Acc & Priority
		) {}
	}
}