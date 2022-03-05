using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Lowers the target's Special Attack by two stages if it's the opposite gender.
	public class MoveCaptivate : Move
	{
		public MoveCaptivate() : base(
			"Captivate",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			20, null,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}