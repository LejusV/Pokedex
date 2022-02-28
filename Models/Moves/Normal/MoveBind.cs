using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Prevents the target from fleeing and inflicts damage for 2-5 turns.
	public class MoveBind : Move
	{
		public MoveBind() : base(
			"Bind",
			Normal.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			20, 15,// PP & Pow
			85, 0 // Acc & Priority
		) {}
	}
}