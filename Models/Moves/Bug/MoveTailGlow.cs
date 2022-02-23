using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Raises the user's Special Attack by three stages.
	public class MoveTailGlow : Move
	{
		public MoveTailGlow() : base(
			"Tail-Glow",
			Bug.Instance, // Move Type
			MoveCategory.Status, // Move Category
			20, null,// PP & Pow
			null, 0 // Acc & Priority
			
		) {}
	}
}