using Pokedex.Enums;
using Pokedex.Models.PokeTypes;

namespace Pokedex.Models.Moves
{
	//Prevents any priority moves from hitting friendly Pokémon this turn.
	public class MoveQuickGuard : Move
	{
		public MoveQuickGuard() : base(
			"Quick-Guard",
			Fighting.Instance, // Move Type
			MoveCategory.Status, // Move Category
			15, null,// PP & Pow
			null, 3 // Acc & Priority
		) {}
	}
}