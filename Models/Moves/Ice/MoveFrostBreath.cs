using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Always scores a critical hit.
	public class MoveFrostBreath : Move
	{
		public MoveFrostBreath() : base(
			"Frost-Breath",
			Ice.Instance, // Move Type
			MoveCategory.Special, // Move Category
			10, 60,// PP & Pow
			0.9, 0 // Acc & Priority
		) {}
	}
}