using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Has an increased chance for a critical hit and a 10% chance to burn the target.
	public class MoveBlazeKick : Move
	{
		public MoveBlazeKick() : base(
			"Blaze-Kick",
			Fire.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 85,// PP & Pow
			0.9, 0 // Acc & Priority
		) {}
	}
}