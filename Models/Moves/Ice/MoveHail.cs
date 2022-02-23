using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Changes the weather to a hailstorm for five turns.
	public class MoveHail : Move
	{
		public MoveHail() : base(
			"Hail",
			Ice.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			null, 0 // Acc & Priority
			
		) {}
	}
}