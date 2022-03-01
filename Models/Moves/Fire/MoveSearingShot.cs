using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Has a 30% chance to burn the target.
	public class MoveSearingShot : Move
	{
		public MoveSearingShot() : base(
			"Searing-Shot",
			Fire.Instance, // Move Type
			MoveCategory.Special, // Move Category
			5, 100,// PP & Pow
			1.0, 0 // Acc & Priority
		) {}
	}
}