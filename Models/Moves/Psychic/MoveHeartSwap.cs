using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//User and target swap stat changes.
	public class MoveHeartSwap : Move
	{
		public MoveHeartSwap() : base(
			"Heart-Swap",
			Psychic.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			null, 0 // Acc & Priority
			
		) {}
	}
}