using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Lowers the target's Special Attack by one stage.
	public class MoveConfide : Move
	{
		public MoveConfide() : base(
			"Confide",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			20, null,// PP & Pow
			null, 0 // Acc & Priority
			
		) {}
	}
}