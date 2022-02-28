using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Inflicts double damage if the target is Poisoned.
	public class MoveVenoshock : Move
	{
		public MoveVenoshock() : base(
			"Venoshock",
			Poison.Instance, // Move Type
			MoveCategory.Special, // Move Category
			10, 65,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}