using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//
	public class MoveBehemothBlade : Move
	{
		public MoveBehemothBlade() : base(
			"Behemoth-Blade",
			Steel.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			5, 100,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}