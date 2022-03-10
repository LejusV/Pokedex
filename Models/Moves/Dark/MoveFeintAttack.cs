using Pokedex.Enums;
using Pokedex.Models.PokeTypes;

namespace Pokedex.Models.Moves
{
	//Never misses.
	public class MoveFeintAttack : Move
	{
		public MoveFeintAttack() : base(
			"Feint-Attack",
			Dark.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			20, 60,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}