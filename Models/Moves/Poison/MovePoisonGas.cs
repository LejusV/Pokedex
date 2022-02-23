using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Poisons the target.
	public class MovePoisonGas : Move
	{
		public MovePoisonGas() : base(
			"Poison-Gas",
			Poison.Instance, // Move Type
			MoveCategory.Status, // Move Category
			40, null,// PP & Pow
			90, 0 // Acc & Priority
			
		) {}
	}
}