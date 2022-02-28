using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Prevents any multi-target moves from hitting friendly Pokémon this turn.
	public class MoveWideGuard : Move
	{
		public MoveWideGuard() : base(
			"Wide-Guard",
			Rock.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			null, 3 // Acc & Priority
		) {}
	}
}