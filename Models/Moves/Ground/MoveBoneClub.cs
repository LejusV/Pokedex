using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Has a 10% chance to make the target flinch.
	public class MoveBoneClub : Move
	{
		public MoveBoneClub() : base(
			"Bone-Club",
			Ground.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			20, 65,// PP & Pow
			85, 0 // Acc & Priority
		) {}
	}
}