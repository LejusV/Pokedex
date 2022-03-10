using Pokedex.Enums;
using Pokedex.Models.PokeTypes;

namespace Pokedex.Models.Moves
{
	//Raises the user's Defense by one stage.
	public class MoveWithdraw : Move
	{
		public MoveWithdraw() : base(
			"Withdraw",
			Water.Instance, // Move Type
			MoveCategory.Status, // Move Category
			40, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}