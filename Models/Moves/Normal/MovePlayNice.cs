using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Lowers the target's Attack by one stage.
	public class MovePlayNice : Move
	{
		public MovePlayNice() : base(
			"Play-Nice",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			20, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}