using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Covers the opposing field, lowering opponents' Speed by one stage upon switching in.
	public class MoveStickyWeb : Move
	{
		public MoveStickyWeb() : base(
			"Sticky-Web",
			Bug.Instance, // Move Type
			MoveCategory.Status, // Move Category
			20, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}