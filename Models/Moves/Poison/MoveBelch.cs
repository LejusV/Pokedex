using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Can only be used after the user has eaten a berry.
	public class MoveBelch : Move
	{
		public MoveBelch() : base(
			"Belch",
			Poison.Instance, // Move Type
			MoveCategory.Special, // Move Category
			10, 120,// PP & Pow
			0.9, 0 // Acc & Priority
		) {}
	}
}