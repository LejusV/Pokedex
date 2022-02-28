using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Puts the target to sleep.
	public class MoveLovelyKiss : Move
	{
		public MoveLovelyKiss() : base(
			"Lovely-Kiss",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			75, 0 // Acc & Priority
		) {}
	}
}