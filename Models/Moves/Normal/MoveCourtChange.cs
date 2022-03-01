using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//
	public class MoveCourtChange : Move
	{
		public MoveCourtChange() : base(
			"Court-Change",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			1.0, 0 // Acc & Priority
		) {}
	}
}