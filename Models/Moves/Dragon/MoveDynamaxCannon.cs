using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Sets Light Screen on the user's side of the field after inflicting damage.
	public class MoveDynamaxCannon : Move
	{
		public MoveDynamaxCannon() : base(
			"Dynamax-Cannon",
			Dragon.Instance, // Move Type
			MoveCategory.Special, // Move Category
			5, 100,// PP & Pow
			100, 0 // Acc & Priority
			
		) {}
	}
}