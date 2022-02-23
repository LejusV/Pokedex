using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//
	public class MoveDecorate : Move
	{
		public MoveDecorate() : base(
			"Decorate",
			Fairy.Instance, // Move Type
			MoveCategory.Status, // Move Category
			15, null,// PP & Pow
			null, 0 // Acc & Priority
			
		) {}
	}
}