using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//User receives 1/4 the damage it inflicts in recoil.
	public class MoveWildCharge : Move
	{
		public MoveWildCharge() : base(
			"Wild-Charge",
			Electric.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			15, 90,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}