using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Lowers the target's Attack, Special Attack, and Speed by one stage if it is poisoned.
	public class MoveVenomDrench : Move
	{
		public MoveVenomDrench() : base(
			"Venom-Drench",
			Poison.Instance, // Move Type
			MoveCategory.Status, // Move Category
			20, null,// PP & Pow
			100, 0 // Acc & Priority
			
		) {}
	}
}