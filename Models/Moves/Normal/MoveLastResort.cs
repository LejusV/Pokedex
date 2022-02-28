using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Can only be used after all of the user's other moves have been used.
	public class MoveLastResort : Move
	{
		public MoveLastResort() : base(
			"Last-Resort",
			Normal.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			5, 140,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}