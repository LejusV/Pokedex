using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Has a 20% chance to make the target flinch.
	public class MoveDarkPulse : Move
	{
		public MoveDarkPulse() : base(
			"Dark-Pulse",
			Dark.Instance, // Move Type
			MoveCategory.Special, // Move Category
			15, 80,// PP & Pow
			1.0, 0 // Acc & Priority
		) {}
	}
}