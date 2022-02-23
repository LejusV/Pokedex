using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//
	public class MoveClangorousSoul : Move
	{
		public MoveClangorousSoul() : base(
			"Clangorous-Soul",
			Dragon.Instance, // Move Type
			MoveCategory.Status, // Move Category
			5, null,// PP & Pow
			100, 0 // Acc & Priority
			
		) {}
	}
}