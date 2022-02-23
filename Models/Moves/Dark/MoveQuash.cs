using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Makes the target act last this turn.
	public class MoveQuash : Move
	{
		public MoveQuash() : base(
			"Quash",
			Dark.Instance, // Move Type
			MoveCategory.Status, // Move Category
			15, null,// PP & Pow
			100, 0 // Acc & Priority
			
		) {}
	}
}