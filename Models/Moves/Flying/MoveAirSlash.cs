using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Has a 30% chance to make the target flinch.
	public class MoveAirSlash : Move
	{
		public MoveAirSlash() : base(
			"Air-Slash",
			Flying.Instance, // Move Type
			MoveCategory.Special, // Move Category
			15, 75,// PP & Pow
			0.95, 0 // Acc & Priority
		) {}
	}
}