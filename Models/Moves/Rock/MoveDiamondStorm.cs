using Pokedex.Enums;
using Pokedex.Models.PokeTypes;

namespace Pokedex.Models.Moves
{
	//Has a 50% chance to raise the user's Defense by two stages for each target hit.
	public class MoveDiamondStorm : Move
	{
		public MoveDiamondStorm() : base(
			"Diamond-Storm",
			Rock.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			5, 100,// PP & Pow
			95, 0 // Acc & Priority
		) {}
	}
}