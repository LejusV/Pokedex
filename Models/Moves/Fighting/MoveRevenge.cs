using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Inflicts double damage if the user takes damage before attacking this turn.
	public class MoveRevenge : Move
	{
		public MoveRevenge() : base(
			"Revenge",
			Fighting.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 60,// PP & Pow
			100, -4 // Acc & Priority
		) {}
	}
}