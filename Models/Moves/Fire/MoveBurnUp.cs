using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Removes the user's fire type after inflicting damage.
	public class MoveBurnUp : Move
	{
		public MoveBurnUp() : base(
			"Burn-Up",
			Fire.Instance, // Move Type
			MoveCategory.Special, // Move Category
			5, 130,// PP & Pow
			1.0, 0 // Acc & Priority
		) {}
	}
}