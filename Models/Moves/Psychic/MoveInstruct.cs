using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Forces the target to repeat its last used move.
	public class MoveInstruct : Move
	{
		public MoveInstruct() : base(
			"Instruct",
			Psychic.Instance, // Move Type
			MoveCategory.Status, // Move Category
			15, null,// PP & Pow
			null, 0 // Acc & Priority
			
		) {}
	}
}