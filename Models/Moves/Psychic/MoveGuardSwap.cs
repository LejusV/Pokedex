using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//User swaps Defense and Special Defense changes with the target.
	public class MoveGuardSwap : Move
	{
		public MoveGuardSwap() : base(
			"Guard-Swap",
			Psychic.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			null, 0 // Acc & Priority
			
		) {}
	}
}