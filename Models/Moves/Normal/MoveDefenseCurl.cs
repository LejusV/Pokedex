using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Raises user's Defense by one stage.
	public class MoveDefenseCurl : Move
	{
		public MoveDefenseCurl() : base(
			"Defense-Curl",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			40, null,// PP & Pow
			null, 0 // Acc & Priority
			
		) {}
	}
}