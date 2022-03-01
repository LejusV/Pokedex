using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//
	public class MoveBehemothBash : Move
	{
		public MoveBehemothBash() : base(
			"Behemoth-Bash",
			Steel.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			5, 100,// PP & Pow
			1.0, 0 // Acc & Priority
		) {}
	}
}