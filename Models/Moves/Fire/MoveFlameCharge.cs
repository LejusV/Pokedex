using Pokedex.Enums;
using Pokedex.Models.PokeTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage.  Raises the user's Speed by one stage.
	public class MoveFlameCharge : Move
	{
		public MoveFlameCharge() : base(
			"Flame-Charge",
			Fire.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			20, 50,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}