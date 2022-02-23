using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//
	public class MoveObstruct : Move
	{
		public MoveObstruct() : base(
			"Obstruct",
			Dark.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			100, 4 // Acc & Priority
			
		) {}
	}
}