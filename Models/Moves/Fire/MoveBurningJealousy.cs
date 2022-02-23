using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveBurningJealousy : Move
	{
		public MoveBurningJealousy() : base(
			"Burning-Jealousy",
			Fire.Instance, // Move Type
			MoveCategory.Special, // Move Category
			5, 70,// PP & Pow
			100, 0 // Acc & Priority
			
		) {}
	}
}