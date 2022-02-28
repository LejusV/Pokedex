using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Never misses.
	public class MoveFalseSurrender : Move
	{
		public MoveFalseSurrender() : base(
			"False-Surrender",
			Dark.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 80,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}