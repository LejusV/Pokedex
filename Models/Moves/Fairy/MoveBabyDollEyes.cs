using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Lowers the target's Attack by one stage.
	public class MoveBabyDollEyes : Move
	{
		public MoveBabyDollEyes() : base(
			"Baby-Doll-Eyes",
			Fairy.Instance, // Move Type
			MoveCategory.Status, // Move Category
			30, null,// PP & Pow
			1.0, 1 // Acc & Priority
		) {}
	}
}