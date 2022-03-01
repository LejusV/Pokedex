using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Cures the target of burns.
	public class MoveSparklingAria : Move
	{
		public MoveSparklingAria() : base(
			"Sparkling-Aria",
			Water.Instance, // Move Type
			MoveCategory.Special, // Move Category
			10, 90,// PP & Pow
			1.0, 0 // Acc & Priority
		) {}
	}
}