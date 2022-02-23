using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Inflicts 40 points of damage.
	public class MoveDragonRage : Move
	{
		public MoveDragonRage() : base(
			"Dragon-Rage",
			Dragon.Instance, // Move Type
			MoveCategory.Special, // Move Category
			10, null,// PP & Pow
			100, 0 // Acc & Priority
			
		) {}
	}
}