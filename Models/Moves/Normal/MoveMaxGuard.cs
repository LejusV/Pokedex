using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Prevents any moves from hitting the user this turn.
	public class MoveMaxGuard : Move
	{
		public MoveMaxGuard() : base(
			"Max-Guard",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			null, 4 // Acc & Priority
			
		) {}
	}
}