using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Has a 100% chance to lower the target's Speed by one stage.
	public class MoveMudShot : Move
	{
		public MoveMudShot() : base(
			"Mud-Shot",
			Ground.Instance, // Move Type
			MoveCategory.Special, // Move Category
			15, 55,// PP & Pow
			0.95, 0 // Acc & Priority
		) {}
	}
}