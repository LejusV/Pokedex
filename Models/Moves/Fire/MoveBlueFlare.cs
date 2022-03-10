using Pokedex.Enums;
using Pokedex.Models.PokeTypes;

namespace Pokedex.Models.Moves
{
	//Has a 20% chance to burn the target.
	public class MoveBlueFlare : Move
	{
		public MoveBlueFlare() : base(
			"Blue-Flare",
			Fire.Instance, // Move Type
			MoveCategory.Special, // Move Category
			5, 130,// PP & Pow
			85, 0 // Acc & Priority
		) {}
	}
}