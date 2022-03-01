using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Has a 10% chance to poison the target.
	public class MoveSludgeWave : Move
	{
		public MoveSludgeWave() : base(
			"Sludge-Wave",
			Poison.Instance, // Move Type
			MoveCategory.Special, // Move Category
			10, 95,// PP & Pow
			1.0, 0 // Acc & Priority
		) {}
	}
}