using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Power doubles if user is burned, paralyzed, or poisoned.
	public class MoveFacade : Move
	{
		public MoveFacade() : base(
			"Facade",
			Normal.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			20, 70,// PP & Pow
			100, 0 // Acc & Priority
			
		) {}
	}
}